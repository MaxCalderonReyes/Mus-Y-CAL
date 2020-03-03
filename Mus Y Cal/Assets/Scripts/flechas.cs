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
    public GameObject[] score;
    
    void Start()
    {
       
        /*
        textPoint = new TextPoint();
        textPoint = GameObject.Find("Points").GetComponent<TextPoint>();*/
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

/*
        if (left)
        {
            if (transform.position.x <= -0.7f)
            {
                state = 0;
                Destroy(gameObject);
            }
        }
        else
        {
            if (transform.position.x >= 0.7f)
            {
                state = 0;
                Destroy(gameObject);
            }
        }*/
       
        
        if (active)
        {

                /*if (distance >= 1.5f && distance <= 3.0f)
                {
                    state = 0;


                }
              if (distance > 0.62f && distance < 1.5f)
                {
                    state = 2;
                  
                }
              if (distance >= 0f && distance <= 0.62f)
                {
                    state = 3;
                  print("eeeooooooooo");
                }*/

           


            if (direccion == "Up")
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (state == 0)
                    {
                        /*textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[0], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 2)
                    {
                        /*
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[1], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 3)
                    {
                        /*
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[2], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    print("top");
                    Destroy(gameObject);
                }
            }

            if (direccion == "Down")
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (state == 0)
                    {
                        /*textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[0], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 2)
                    {
                        /*
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[1], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 3)
                    {
                        /*
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[2], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    print("down");
                    Destroy(gameObject);
                }
            }

            if (direccion == "Left")
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (state == 0)
                    {
                        /*textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[0], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 2)
                    {
                        /*
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[1], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 3)
                    {
                        /*
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[2], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    print("left");
                    Destroy(gameObject);
                }
            }

            if (direccion == "Right")
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (state == 0)
                    {
                        /*textPoint.point.text = "0";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[0], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 2)
                    {
                        /*
                        textPoint.point.text = "250";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[1], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    if (state == 3)
                    {
                        /*
                        textPoint.point.text = "500";
                        textPoint.Grow = true;
                        textPoint.MarkPoint();*/
                        Instantiate(score[2], new Vector3(0.09f, 1.44f, 0), Quaternion.identity);
                    }
                    print("right");
                    Destroy(gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (active)
        //{
            if (other.name == "col1")
            {
                state = 3;
                active = true;
            }
            if (other.name == "col2")
            {
                state = 2;
                active = true;
            }
        //}
        if (other.name == "col3")
            {
                if (!left)
                {
                    state = 0;
                    Destroy(gameObject);
                }
            }
            if (other.name == "col4")
            {
                if (left)
                {
                    state = 0;
                    Destroy(gameObject);
                }
            }
    }

}
