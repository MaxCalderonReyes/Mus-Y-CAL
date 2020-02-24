using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextPoint : MonoBehaviour
{
 
    [SerializeField] public Text point;
    [SerializeField]public bool Grow=true;
    private float TimeToGrow;
    void Start()
    {
     
        point = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MarkPoint();
      
      
    }
    public void MarkPoint()
    {
      
        RectTransform temp = point.GetComponent<RectTransform>();
        if (Grow)
        {
            TimeToGrow += Time.deltaTime * 20;
   
         
            temp.localScale= new Vector3(1*TimeToGrow,1*TimeToGrow,0);
           
            if (temp.localScale.x>=2)
            {
                TimeToGrow = 0;
                Grow = false;

                temp.localScale = new Vector3(0, 0, 0);
              
            }
        }
    
        
    }
   
}
