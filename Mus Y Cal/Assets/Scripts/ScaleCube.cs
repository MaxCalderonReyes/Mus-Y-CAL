using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCube : MonoBehaviour
{
  public int band;
  public float startScale,scaleMultiplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=new Vector3(transform.localScale.x,(MusicScript.spectrum[band]*scaleMultiplayer)+startScale,transform.localScale.z);
    }
}
