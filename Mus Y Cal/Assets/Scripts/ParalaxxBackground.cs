using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxxBackground : MonoBehaviour
{
    [SerializeField] private float ParalaxxEfectMuliply;
    private Transform CamaraTransform;

    private float UnitSizeX;
    // Start is called before the first frame update
    public void Start()
    {
        CamaraTransform = Camera.main.transform;

        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        UnitSizeX = texture.width / sprite.pixelsPerUnit;

    }

    private void LateUpdate()
    {



        transform.position += new Vector3(Time.deltaTime * ParalaxxEfectMuliply, 0, 0);

        if (Mathf.Abs(CamaraTransform.position.x - transform.position.x) >= UnitSizeX)
        {
          
            float offsetPosition = ((transform.position.x / 100) * UnitSizeX);
            transform.position = new Vector3(CamaraTransform.position.x + (-offsetPosition), transform.position.y);
        


        }


    }

}
