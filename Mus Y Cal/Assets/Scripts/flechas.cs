﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechas : MonoBehaviour
{

    public Transform check;
    private int state;
    public string direccion;
    private float distance;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x - 7 * Time.deltaTime, transform.position.y, transform.position.z);
        distance = Vector3.Distance(check.position, transform.position);
        //print(distance);
        print(state);


        /*
        if(transform.position.x <= -1.6f)
        {
            state = 0;
            Destroy(gameObject);
        }
       */
        if(distance >= -0.62f && distance <= 0.62f)
        {
            state = 3;
        }

        if(distance > 0.62f && distance < 1.5f)
        {
            state = 2;
        }

        if(distance >= 1.5f)
        {
            state = 0;
        }


        if (direccion == "Up")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
            }
        }

        if (direccion == "Down")
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

            }
        }

        if (direccion == "Left")
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

            }
        }

        if (direccion == "Right")
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {

            }
        }
    }
}