using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleCube : MonoBehaviour
{
 
   public Color[] colors;
   private Color _CubColor;
  public int band;
  public float startScale,scaleMultiplayer;
  private  Image TempColor;

  
    void Start()
    {	  
      TempColor = GetComponent<Image>();
        _CubColor=GetComponent<Color>();
    }

    // Update is called once per frame
    void Update()
    {
      TempColor.color=_CubColor;
        transform.localScale=new Vector3(transform.localScale.x,(MusicScript.spectrum[band]*scaleMultiplayer)+startScale,transform.localScale.z);

       if(transform.localScale.y>1.0f){
         _CubColor=colors[0];
          if(transform.localScale.y>2.0f){
         _CubColor=colors[1];
    
           if(transform.localScale.y>3.0f){
         _CubColor=colors[2];
       }
       }
       }
       
       else{
         _CubColor=colors[3];
       }

    }
}
