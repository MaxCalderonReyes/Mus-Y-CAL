using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTutorial : MonoBehaviour
{
    public bool temp;
    int count = 0;
    public Canvas canvas;
    public void Start()
    {
        canvas.enabled = false;
    }
    public void activeinfo()
    {

        temp = !temp;
        canvas.enabled = temp;
        

    }
}
