using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public List<flechas> flechas;
    void Start()
    {
        if (instancia == null) instancia = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
