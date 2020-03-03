using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 10 * Time.deltaTime, transform.position.z);

        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, GetComponent<SpriteRenderer>().color.a - 5 * Time.deltaTime);

        if(GetComponent<SpriteRenderer>().color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
