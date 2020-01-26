using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    AudioSource  AudioSource;
   public static float[] spectrum=new float[512];
   public static float[] freqband=new float[8];
    void Start()
    {
        AudioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GEtSpectrumData();
    }
    public void GEtSpectrumData(){
        AudioSource.GetSpectrumData(spectrum,0,FFTWindow.Blackman);
    }
    void MakeFrequenciBands(){
        int count=0;
        for (int i = 0; i < 8; i++)
        {
            float average=0;
            int sampleCount=(int)Mathf.Pow(2,i)*2;
            if(i==7){
                sampleCount+=2;
            }
            for (int j = 0; j < sampleCount; i++)
            {
                average+=spectrum[count]*count+1;
                count++;
            }
            average/=count;
            freqband[i]=average*10;
        }
        
    }
}
