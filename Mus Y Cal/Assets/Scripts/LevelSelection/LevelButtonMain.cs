using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonMain : MonoBehaviour
{
    [SerializeField]private int lvl;
    [SerializeField] private bool Elect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Elect)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(lvl);
            }
        }
    }
    public void CargarLvl(int nivel)
    {
      
            SceneManager.LoadScene(nivel);

      
     
       
    }
   
}
