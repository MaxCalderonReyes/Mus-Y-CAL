using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnterOrLeaveScene : MonoBehaviour
{

    [SerializeField] private float Direccion;
    [SerializeField] public float velocidad;
   
   
    public bool canMove;
    void Start()
    {
        canMove = false;
    }

    public void Update()
    {
        iniciarMovimiento();
    }

    public void iniciarMovimiento()
    {
        if (canMove == true)
        transform.position += new Vector3((Direccion * velocidad) * Time.deltaTime,0, 0);
 
    }
  

}
