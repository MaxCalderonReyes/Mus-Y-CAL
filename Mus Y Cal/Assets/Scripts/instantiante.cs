using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


[System.Serializable]
public class instantiante : MonoBehaviour
{
    private string path;
    public string n_of_mus;
    public GameObject[] arrow;
    public int beat;
    public int ScaleNormal, ExtraScale;
    private int random;
    private bool Shoot;
  
    public List<flechas> amd = new List<flechas>();
   
    //Mientras mas bajo sea el numero mas rapido se instancian
    public float MaxTimeBeat, MinTimeBeat;
    //Obtener datos de la musica en jason
 
    public List<float> BetasToSong;
    public bool RighLefht;
    public bool TopDown;
   
    //Temporales

    private int count = 0;
 
    void Start()
    {
      
        path = Application.dataPath + "/Data/"+n_of_mus+".json";
        Shoot = true;
      
    }

    void vegas()
    {
        foreach (flechas go in GameManager.instancia.flechas)
        {
            bool existe = GameManager.instancia.flechas.Contains(go);
            if (!existe)
            {
                GameManager.instancia.flechas.Add(go);
            }
        }

        for (int i = 0; i < GameManager.instancia.flechas.Count; i++)
        {
                if(i == 0)
                {
                GameManager.instancia.flechas[i].active = true;
                }
                else
                {
                GameManager.instancia.flechas[i].active = false;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float sound= (MusicScript.spectrum[beat] * ExtraScale)+ScaleNormal;
        BetasToSong.Add(sound);
        Json DT = new Json(BetasToSong);
        string dtos = JsonUtility.ToJson(DT, false);
        File.WriteAllText(path, dtos);
        */
        //////////////////////////////////
        
        string Mus = File.ReadAllText(path);
        Json beats = JsonUtility.FromJson<Json>(Mus);

        float current = beats.Song[count];

        count += 1;

            if (Shoot)
        {
            vegas();
            if (current > 3.0f && current < 3.5f)
            {
                if (TopDown)
                {
                    Instantiate(arrow[3], transform.position, Quaternion.identity);


                    StartCoroutine(CanShoot()); return;
                }
               

            }
            if (current > 2.5f)
            {
                if (TopDown)
                {
                    Instantiate(arrow[2], transform.position, Quaternion.identity);

                    StartCoroutine(CanShoot()); return;
                }
               

            }
            if (current > 2.0f)
            {
                if (RighLefht)
                {
                    Instantiate(arrow[1], transform.position, Quaternion.identity);

                    StartCoroutine(CanShoot()); return;
                }
              

            }
            if (current > 1.5f )
            {
                if (RighLefht)
                {
                    Instantiate(arrow[0], transform.position, Quaternion.identity);

                    StartCoroutine(CanShoot()); return;
                }
                

            }



        }

        for (int i = 0; i < GameManager.instancia.flechas.Count; i++)
        {
            if (GameManager.instancia.flechas[i] == null)
            {
                GameManager.instancia.flechas.Remove(GameManager.instancia.flechas[i]);
            }
        }
        
    }
    public IEnumerator CanShoot()
    {
        Shoot = false;
        yield return new WaitForSecondsRealtime(Random.Range(MinTimeBeat,MaxTimeBeat));
        Shoot = true;
    }
}

