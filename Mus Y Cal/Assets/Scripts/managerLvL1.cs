using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerLvL1 : MonoBehaviour
{
    
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
        print(timer);

        timer += Time.deltaTime;

        if(timer >= 245 || Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.SetFloat("Puntos1", tosc.Points);
            SceneManager.LoadScene(1);
        }
    }
}
