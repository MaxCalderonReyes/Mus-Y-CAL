using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechasManager : MonoBehaviour
{
    public GameObject[] orden;
    private int numOrden;

    void Start()
    {
        numOrden = 0;
    }


    void Update()
    {
        print(AudioColor.spawn);

        if(AudioColor.spawn)
        {
            print("spawn");
            Instantiate(orden[numOrden], transform.position, Quaternion.identity);
            numOrden++;
            AudioColor.spawn = false;
        }
    }
}
