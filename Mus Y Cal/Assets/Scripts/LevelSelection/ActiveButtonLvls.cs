using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveButtonLvls : MonoBehaviour
{
    public static ActiveButtonLvls instancia;
    public Button[] listaBotones;
    [SerializeField] private bool Active;
    public SpriteRenderer[] sprt;
    public GameObject[] candado;

    void Start()
    {
        
        if (instancia == null) instancia = this;
       
            listaBotones[0].interactable = false;
        listaBotones[1].interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) )
        {
            print("A");
            listaBotones[0].interactable = true;
            print("Activo");
           sprt[0].color = new Color(255, 255, 255, 255);
            print("cambio de color");
      candado[0].SetActive(false);
            print("se fue el candado");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            listaBotones[1].interactable = true;
          sprt[1].color = new Color(255, 255, 255, 255);
         
           candado[1].SetActive(false);
        }
    }
}
