using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private bool Pause=false;
    public GameObject buttonPause;

    public void Start()
    {
        buttonPause.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
      
        Pause = !Pause;
        buttonPause.SetActive(!Pause);
        Time.timeScale = (Pause) ? 1 : 0;
       

    }
   public void SeleccionLevel()
    {
        SceneManager.LoadScene("Mapa");
    }
   public void reinicarScena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  public  void SiguienteEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
