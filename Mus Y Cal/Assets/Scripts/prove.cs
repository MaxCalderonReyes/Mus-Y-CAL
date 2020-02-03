using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class prove : MonoBehaviour
{
    public void Awake()
    {
        if (instance == null) instance = this;
    }
    public static prove instance;
     [SerializeField]public  List<float> temporal;

  
}
