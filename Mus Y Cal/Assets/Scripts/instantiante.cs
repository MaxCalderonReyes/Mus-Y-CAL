using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiante : MonoBehaviour
{
    public GameObject[] arrow;
    public int beat;
    public int ScaleNormal, ExtraScale;
    private int random;
    private bool Shoot;
    //Mientras mas bajo sea el numero mas rapido se instancian
    public float MaxTimeBeat,MinTimeBeat;
    
    void Start()
    {

        Shoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        float sound= (MusicScript.spectrum[beat] * ExtraScale)+ScaleNormal;
        if(sound>beat && Shoot)
        {
            random = Random.Range(0, arrow.Length);
            GameObject pref = Instantiate(arrow[random]);
            pref.transform.position = this.transform.position;
            pref.transform.rotation = Quaternion.identity;
            StartCoroutine(CanShoot());
        }
    }
    public IEnumerator CanShoot()
    {
        Shoot = false;
        yield return new WaitForSecondsRealtime(Random.Range(MinTimeBeat,MaxTimeBeat));
        Shoot = true;
    }
}
