using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
    private float[] _audioSpectrum;
    public static float ValueSpectrum {get;private set;}
  
    void Start()
    {
        _audioSpectrum=new float[128];
    }

    // Update is called once per frame
    void Update()
    {
     
        AudioListener.GetSpectrumData(_audioSpectrum,0,FFTWindow.Blackman);
        if(_audioSpectrum!=null && _audioSpectrum.Length>0){
            ValueSpectrum=_audioSpectrum[0] *100;
        }
    }
}
