﻿using System.Collections;
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
   
   
    //Temporales



    private int count = 0;
 
   
    void Start()
    {
      
        path = Application.dataPath + "/Data/"+n_of_mus+".json";
        Shoot = true;
      
    }

    void vegas()
    {
        foreach (flechas go in FindObjectsOfType<flechas>())
        {
            bool existe = amd.Contains(go);
            if (!existe)
            {
                amd.Add(go);
            }
        }

        for (int i = 0; i < amd.Count; i++)
        {
                if(i == 0)
                {
                    amd[i].active = true;
                }
                else
                {
                    amd[i].active = false;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {

        // float sound= (MusicScript.spectrum[beat] * ExtraScale)+ScaleNormal;
        //   BetasToSong.Add(sound);
        //    Json DT = new Json(BetasToSong);
        //   string dtos = JsonUtility.ToJson(DT, false);
        //    File.WriteAllText(path, dtos);
        //////////////////////////////////

        string Mus = File.ReadAllText(path);
        Json beats = JsonUtility.FromJson<Json>(Mus);

        float current = beats.Song[count];


        count += 1;


        





            if (Shoot)
        {
            vegas();
            if (current > 5.0f)
            {
                Instantiate(arrow[3], transform.position, Quaternion.identity);
                

                StartCoroutine(CanShoot()); return;

            }
            if (current > 4.0f)
            {
                Instantiate(arrow[2], transform.position, Quaternion.identity);

                StartCoroutine(CanShoot()); return;

            }
            if (current > 3.0f)
            {
                Instantiate(arrow[1], transform.position, Quaternion.identity);

                StartCoroutine(CanShoot()); return;

            }
            if (current > 2.0f)
            {
                Instantiate(arrow[0], transform.position, Quaternion.identity);

                StartCoroutine(CanShoot()); return;

            }



        }

        for (int i = 0; i < amd.Count; i++)
        {
            if (amd[i] == null)
            {
                amd.Remove(amd[i]);
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

