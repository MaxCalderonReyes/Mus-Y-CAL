using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class managerMapa : MonoBehaviour
{
    private float P1, P2, P3;
    public Text[] TxT;
    public Image[] Stars1;
    public Image[] Stars2;
    public Image[] Stars3;
    
    public ActiveButtonLvls activador;

    void Start()
    {
        if (PlayerPrefs.HasKey("Puntos1"))
        {
           P1 =  PlayerPrefs.GetFloat("Puntos1");
        }
        else
        {
            P1 = 0;
        }
        if (PlayerPrefs.HasKey("Puntos2"))
        {
            P2 = PlayerPrefs.GetFloat("Puntos2", P2);
        }
        else
        {
            P2 = 0;
        }
        if (PlayerPrefs.HasKey("Puntos2"))
        {
            P3 = PlayerPrefs.GetFloat("Puntos2", P2);
        }
        else
        {
            P3 = 0;
        }

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            print("Delete");
            PlayerPrefs.DeleteAll();
        }
        // Texto ///////////////////////////////////////////
        if(P1 != 0)
        {
            TxT[0].text = P1.ToString();
        }
        else
        {
            TxT[0].text = "Puntaje";
        }
        if (P2 != 0)
        {
            TxT[1].text = P2.ToString();
        }
        else
        {
            TxT[1].text = "Puntaje";
        }
        if (P3 != 0)
        {
            TxT[2].text = P3.ToString();
        }
        else
        {
            TxT[2].text = "Puntaje";
        }

        ////////////////////////////////////////////////////////
        
        if(P1 >= 25000 && P1 < 35000)
        {
            Stars1[0].color = new Color(255, 255, 0, 255);
        }

        else if (P1 >= 35000 && P1 < 45000)
        {
            Stars1[0].color = new Color(255, 255, 0, 255);
            Stars1[1].color = new Color(255, 255, 0, 255);
        }

        else if (P1 >= 45000 && P1 < 55000)
        {
            Stars1[0].color = new Color(255, 255, 0, 255);
            Stars1[1].color = new Color(255, 255, 0, 255);
            Stars1[2].color = new Color(255, 255, 0, 255);
        }

        else if (P1 >= 55000 && P1 < 65000)
        {
            Stars1[0].color = new Color(255, 255, 0, 255);
            Stars1[1].color = new Color(255, 255, 0, 255);
            Stars1[2].color = new Color(255, 255, 0, 255);
            Stars1[3].color = new Color(255, 255, 0, 255);
        }

        else if (P1 >= 65000)
        {
            Stars1[0].color = new Color(255, 255, 0, 255);
            Stars1[1].color = new Color(255, 255, 0, 255);
            Stars1[2].color = new Color(255, 255, 0, 255);
            Stars1[3].color = new Color(255, 255, 0, 255);
            Stars1[4].color = new Color(255, 255, 0, 255);
        }
        else
        {
            Stars1[0].color = new Color(255, 255, 255, 255);
            Stars1[1].color = new Color(255, 255, 255, 255);
            Stars1[2].color = new Color(255, 255, 255, 255);
            Stars1[3].color = new Color(255, 255, 255, 255);
            Stars1[4].color = new Color(255, 255, 255, 255);
        }
        ///////////////////////////////////////////////////////

        if (P2 >= 10000 && P2 < 25000)
        {
            Stars2[0].color = new Color(255, 255, 0, 255);
        }

        else if (P2 >= 25000 && P2 < 30000)
        {
            Stars2[0].color = new Color(255, 255, 0, 255);
            Stars2[1].color = new Color(255, 255, 0, 255);
        }

        else if (P2 >= 30000 && P2 < 45000)
        {
            Stars2[0].color = new Color(255, 255, 0, 255);
            Stars2[1].color = new Color(255, 255, 0, 255);
            Stars2[2].color = new Color(255, 255, 0, 255);
        }

        else if (P2 >= 45000 && P2 < 50000)
        {
            Stars2[0].color = new Color(255, 255, 0, 255);
            Stars2[1].color = new Color(255, 255, 0, 255);
            Stars2[2].color = new Color(255, 255, 0, 255);
            Stars2[3].color = new Color(255, 255, 0, 255);
        }

        else if (P2 >= 50000)
        {
            Stars2[0].color = new Color(255, 255, 0, 255);
            Stars2[1].color = new Color(255, 255, 0, 255);
            Stars2[2].color = new Color(255, 255, 0, 255);
            Stars2[3].color = new Color(255, 255, 0, 255);
            Stars2[4].color = new Color(255, 255, 0, 255);
        }
        else
        {
            Stars2[0].color = new Color(255, 255, 255, 255);
            Stars2[1].color = new Color(255, 255, 255, 255);
            Stars2[2].color = new Color(255, 255, 255, 255);
            Stars2[3].color = new Color(255, 255, 255, 255);
            Stars2[4].color = new Color(255, 255, 255, 255);
        }
        //////////////////////////////////////////////////////////////

        if (P3 >= 10000 && P3 < 25000)
        {
            Stars3[0].color = new Color(255, 255, 0, 255);
        }

        else if (P3 >= 25000 && P3 < 30000)
        {
            Stars3[0].color = new Color(255, 255, 0, 255);
            Stars3[1].color = new Color(255, 255, 0, 255);
        }

        else if (P3 >= 30000 && P3 < 45000)
        {
            Stars3[0].color = new Color(255, 255, 0, 255);
            Stars3[1].color = new Color(255, 255, 0, 255);
            Stars3[2].color = new Color(255, 255, 0, 255);
        }

        else if (P3 >= 45000 && P3 < 50000)
        {
            Stars3[0].color = new Color(255, 255, 0, 255);
            Stars3[1].color = new Color(255, 255, 0, 255);
            Stars3[2].color = new Color(255, 255, 0, 255);
            Stars3[3].color = new Color(255, 255, 0, 255);
        }

        else if (P3 >= 50000)
        {
            Stars3[0].color = new Color(255, 255, 0, 255);
            Stars3[1].color = new Color(255, 255, 0, 255);
            Stars3[2].color = new Color(255, 255, 0, 255);
            Stars3[3].color = new Color(255, 255, 0, 255);
            Stars3[4].color = new Color(255, 255, 0, 255);
        }
        else
        {
            Stars3[0].color = new Color(255, 255, 255, 255);
            Stars3[1].color = new Color(255, 255, 255, 255);
            Stars3[2].color = new Color(255, 255, 255, 255);
            Stars3[3].color = new Color(255, 255, 255, 255);
            Stars3[4].color = new Color(255, 255, 255, 255);
        }

        if (Input.GetKeyDown(KeyCode.P) || PlayerPrefs.HasKey("Puntos1"))
        {
            print("A");
            activador.listaBotones[0].interactable = true;
            print("Activo");
            activador.sprt[0].color = new Color(255, 255, 255, 255);
            print("cambio de color");
            activador.candado[0].SetActive(false);
            print("se fue el candado");
        }
        if (Input.GetKeyDown(KeyCode.O) || PlayerPrefs.HasKey("Puntos2"))
        {
            activador.listaBotones[1].interactable = true;
            activador.sprt[1].color = new Color(255, 255, 255, 255);

            activador.candado[1].SetActive(false);
        }
    }
}
