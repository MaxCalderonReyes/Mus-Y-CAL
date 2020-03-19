using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveButtonLvls : MonoBehaviour
{
    [SerializeField] private bool Active;
    [SerializeField] private int Nivl;
    [SerializeField] public GameObject lvl;
    void Start()
    {
        if(!Active)
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {/*
       //if(Aca ingresa dato para que se active && Nivl == 2)
        {
            lvl.SetActive(true);
        }
        //if(Aca ingresa dato para que se active && Nivl == 2)
        {
            lvl.SetActive(true);
        }*/
    }
}
