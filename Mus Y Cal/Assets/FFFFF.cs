using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFFFF : MonoBehaviour
{
    public GameObject TemporalCheck;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(TemporalCheck.transform.position, 0.62f);
        Gizmos.DrawWireSphere(TemporalCheck.transform.position, 1.5f);
        Gizmos.DrawWireSphere(TemporalCheck.transform.position, 3.0f);
    }
}
