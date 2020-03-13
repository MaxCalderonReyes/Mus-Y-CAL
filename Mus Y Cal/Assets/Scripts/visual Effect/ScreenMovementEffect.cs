using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMovementEffect : MonoBehaviour
{
    [SerializeField]private float moviliti;
    float mouseposY;
    float mouseposX;
    float startposx;
    float starposy;
    void Start()
    {
        startposx = transform.position.x;
        starposy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        mouseposX = Input.mousePosition.x;
        mouseposY = Input.mousePosition.y;
        this.GetComponent<Transform>().position = new Vector2(((mouseposX / Screen.width) * moviliti)+startposx ,
            ((mouseposY / Screen.height) * moviliti) +starposy );
       // print((mouseposY / Screen.height) + (moviliti / 1000));
    }
}
