using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechas : MonoBehaviour
{

    public Transform check;
    private int state;
    public string direccion;
    public float distance;
    private float timer = 0;
    public bool active = false;
    void Start()
    {
        Destroy(gameObject, 6);
    }


    void Update()
    {
        timer += Time.deltaTime;
        transform.position = new Vector3(transform.position.x - 7 * Time.deltaTime, transform.position.y, transform.position.z);
        distance = Vector3.Distance(check.position, transform.position);
     
        //print(distance);
        //print(state);


        
        if(transform.position.x <= -1.04f)
        {
            state = 0;
            Destroy(gameObject);
        }
        
        if (active)
        {
            if (distance >= 0f && distance <= 0.62f)
            {
                state = 3;
            }

            if (distance > 0.62f && distance < 1.5f)
            {
                state = 2;
            }

            if (distance >= 1.5f)
            {
                state = 0;
            }


            if (direccion == "Up")
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Destroy(gameObject);
                }
            }

            if (direccion == "Down")
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Destroy(gameObject);
                }
            }

            if (direccion == "Left")
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Destroy(gameObject);
                }
            }

            if (direccion == "Right")
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
