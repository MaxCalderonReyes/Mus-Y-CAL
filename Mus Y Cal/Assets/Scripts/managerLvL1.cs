using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerLvL1 : MonoBehaviour
{
    public static managerLvL1 instancia;
    [SerializeField] public List<GameObject> listWinelements;
    [SerializeField] public List<GameObject> listLoselements;
    public float pruebasss;
    public TotalScore tosc;
    public Canvas youWin;
    public Canvas youLose;
    private float timer;
    //scale
    private float speed=2f;
    private float duration=5f;
    public bool activescale = true;
    public float rate = 0;
    public bool CanPause=false;
    //pararFondoAvansarPlayer
    
    [SerializeField]private List<ParalaxxBackground> fondos;
    [SerializeField]private ObjectEnterOrLeaveScene  objects;
    // Start is called before the first frame update
    void Start()
    {
        if (instancia == null) instancia = this;

            activescale = true;
        youWin.enabled = false;
        youLose.enabled = false;
        timer = 0;
        tosc.Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
     


        timer += Time.deltaTime;

        if (timer >= 5)
        {
            rate += Time.deltaTime;
            PlayerPrefs.SetFloat("Puntos1", tosc.Points);
            if (tosc.Points >= 5)
            {
               
                StartCoroutine(wait());
                CanPause = true;
                objects.canMove = true;

                if (activescale)
                {

                    for (int i = 1; i < listWinelements.Count; i++)
                    {
                        listWinelements[i].transform.localScale = new Vector3(rate, rate, rate);
                    }


                    youWin.enabled = true;


                    if (rate > 1)
                    {

                        activescale = false;
                    }

                }

            }
            else
            {
                CanPause = true;
             StartCoroutine(waitLose());
                
              PlayerAnim.instancia.animacion.SetBool("Down",true);


                PlayerAnim.instancia.FinCaida();
                


            }

          
        }
    }
    IEnumerator wait()
    {
        objects.velocidad -= pruebasss * Time.deltaTime;
      


        if (objects.velocidad <= 0)
        {
            objects.velocidad = 0;
          

        }
        if (objects.velocidad <= 1)
        {
         
            PlayerAnim.instancia.animacion.SetBool("GetOffTheScene", true);

        }

        for (int j = 0; j < fondos.Count; j++)
        {
            fondos[j].ParalaxxEfectMuliply+=pruebasss*Time.deltaTime;
           
            if (fondos[j].ParalaxxEfectMuliply >= 0)
            {
                fondos[j].ParalaxxEfectMuliply = 0;

            
            }
           
        }
        yield return null;
    }
    IEnumerator waitLose()
    {
        for (int j = 0; j < fondos.Count; j++)
        {
            fondos[j].ParalaxxEfectMuliply += pruebasss * Time.deltaTime;

            if (fondos[j].ParalaxxEfectMuliply >= 0)
            {
                fondos[j].ParalaxxEfectMuliply = 0;

            }

        }
        yield return null;
    }
   
}