using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private bool Pause=false;
    public GameObject buttonPause;
    public SpriteRenderer imagen;
   
    public void Start()
    {
        buttonPause.SetActive(false);
        imagen.enabled = false;
    }
    public void Update()
    {
        if(managerLvL1.instancia.CanPause==false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PauseGame();
            }
        }
      
    }
    public void PauseGame()
    {
        
        Pause = !Pause;
        buttonPause.SetActive(Pause);
      
        Time.timeScale = (Pause) ? 0 : 1;
        imagen.enabled = Pause;


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
