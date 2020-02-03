using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
[System.Serializable]
public class instantiante : MonoBehaviour
{

    public GameObject[] arrow;
    public int beat;
    public int ScaleNormal, ExtraScale;
    private int random;
    private bool Shoot;
    //Mientras mas bajo sea el numero mas rapido se instancian
    public float MaxTimeBeat, MinTimeBeat;
    //Obtener datos de la musica en jason
    private string Path;
    public List<float> BetasToSong;
    public List<prove> CollecionSong;
    //Temporales



    private int count = 0;
 
   
    void Start()
    {
     
        Path = Application.dataPath + "/Data/Json.json";
        Shoot = true;
      
    }

    // Update is called once per frame
    void Update()
    {
      
        float sound= (MusicScript.spectrum[beat] * ExtraScale)+ScaleNormal;
       // BetasToSong.Add(sound);
        //  Json DT = new Json(BetasToSong);
        //  string dtos = JsonUtility.ToJson(DT,false);
         // File.WriteAllText(Path, dtos);
        //////////////////////////////////

      string Mus=  File.ReadAllText(Path);
        Json beats = JsonUtility.FromJson<Json>(Mus);
        
       float current = beats.Song[count];
       prove.instance.temporal  = beats.Song;
       
        count += 1;
        
      // CollecionSong[0] = prove.instance.temporal;
     
     //  Json TEMP = new Json(CollecionSong, 0);
      //  string Dato = JsonUtility.ToJson(TEMP, false);
      //  File.WriteAllText(Path, Dato);
      
       


        if (Shoot)
        {
       
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
    }
    public IEnumerator CanShoot()
    {
        Shoot = false;
        yield return new WaitForSecondsRealtime(Random.Range(MinTimeBeat,MaxTimeBeat));
        Shoot = true;
    }
}

