using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCube : MonoBehaviour
{
 
   public Color[] colors;
   private Color _CubColor;
  public int band;
  public float startScale,scaleMultiplayer;
  private Renderer TempColor;

  
    void Start()
    {	  
      TempColor = GetComponent<Renderer>();
        _CubColor=GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
      TempColor.material.color=_CubColor;
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
