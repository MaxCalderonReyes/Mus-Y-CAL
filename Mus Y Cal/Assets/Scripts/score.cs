using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{

    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime;
        transform.localScale += new Vector3(0.2f * Time.deltaTime, 0.2f * Time.deltaTime, 0);
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, GetComponent<SpriteRenderer>().color.a - Time.deltaTime);

        if (GetComponent<SpriteRenderer>().color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
