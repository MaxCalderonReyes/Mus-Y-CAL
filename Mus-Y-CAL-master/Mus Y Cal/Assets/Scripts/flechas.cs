using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flechas : MonoBehaviour
{

    public TextPoint textPoint;
    public Transform check;
    [SerializeField]public int state;
    public string direccion;
    public float distance;
    private float timer = 0;
    public bool active = false;
    public bool left=true;
    
    void Start()
    {
       
        
        textPoint = new TextPoint();
        textPoint = GameObject.Find("Points").GetComponent<TextPoint>();
        Destroy(gameObject, 6);
        
    }


    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (left)
        {
            transform.position = new Vector3(transform.position.x - 7 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + 7 * Time.deltaTime, transform.position.y, transform.position.z);
        }
      
        distance = Vector3.Distance(check.position, transform.position);

        //print(distance);
        //print(state);


        if (left)
        {
            if (transform.position.x <= 0f)
            {
                state = 0;
                Destroy(gameObject);
            }
        }
        else
        {
            if (transform.position.x >= 0f)
            {
                state = 0;
                Destroy(gameObject);
            }
        }
       
        
        if (active)
        {
            if (left)
            {
                if (distance >= 1.5f && distance <= 3.0f)
                {
                    state = 0;
                    print("state0");

                }
                else if (distance > 0.62f && distance < 1.5f)
                {
                    state = 2;
                    print("state2");
                }
              else if (distance >= 0f && distance <= 0.62f)
                {
                    state = 3;
                    print("state3");
                }





            }
           else
            {
                if (distance <= 1.5f && distance >= -3.0f)
                {
                    state = 0;
                    if (distance < -0.62f && distance > -1.5f)
                    {
                        state = 2;
                        if (distance <= 0f && distance >= -0.62f)
                        {
                            state = 3;
                        }
                    }
                }
             
    
              

               
            }
           
            print(state);

            if (direccion == "Up")
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (state == 0)
                    {
                        textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 2)
                    {
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 3)
                    {
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    Destroy(gameObject);
                }
            }

            if (direccion == "Down")
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (state == 0)
                    {
                        textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 2)
                    {
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 3)
                    {
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    Destroy(gameObject);
                }
            }

            if (direccion == "Left")
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (state == 0)
                    {
                        textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 2)
                    {
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 3)
                    {
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    Destroy(gameObject);
                }
            }

            if (direccion == "Right")
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (state == 0)
                    {
                        textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 2)
                    {
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    if (state == 3)
                    {
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();
                    }
                    Destroy(gameObject);
                }
            }
        }
    }

}
