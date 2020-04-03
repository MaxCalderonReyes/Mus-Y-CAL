using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerLvL1 : MonoBehaviour
{
    [HideInInspector]
    public TotalScore tosc;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        tosc.Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 260 || Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.GetFloat("Puntos1", tosc.Points);
            SceneManager.LoadScene(1);
        }
    }
}
