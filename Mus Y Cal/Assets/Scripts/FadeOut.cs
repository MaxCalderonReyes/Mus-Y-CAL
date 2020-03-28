using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private CanvasGroup canvas;

    void Start()
    {
        canvas = GameObject.Find("centralCanvas").GetComponent<CanvasGroup>();
        canvas.alpha = 0f;
    }

    void Update()
    {
        if(canvas.alpha < 1)
            canvas.alpha += 0.4f * Time.deltaTime;
    }
}
