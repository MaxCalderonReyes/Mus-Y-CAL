using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
       
    }
}
