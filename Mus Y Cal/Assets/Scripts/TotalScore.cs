using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TotalScore : MonoBehaviour
{
    public List<GameObject> stars;
    public Text Score;
    private int Puntos;

    public int Points
    {
        get { return Puntos; }
        set { Puntos = value; }
    }
    void Start()
    {
        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(Points);
        int temp = Points;
        print(temp);
        
        Score.text = Points.ToString();
        if (Points > 5000)
        {
            stars[0].SetActive(true);

            if (Points > 15000)
            {
                stars[1].SetActive(true);
                if (Points > 20000)
                {
                    stars[2].SetActive(true);
                    if (Points > 25000)
                    {
                        stars[3].SetActive(true);
                        if (Points > 30000)
                        {
                            stars[4].SetActive(true);

                        }
                    }
                }
            }
        }
    }
}
