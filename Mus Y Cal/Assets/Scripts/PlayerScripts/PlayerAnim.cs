using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public static PlayerAnim instancia;
    public Animator animacion;
    public managerLvL1 manager;
    void Start()
    {
        if (instancia == null) instancia = this;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FinCaida()
    {
        if (manager.activescale)
        {

            for (int i = 1; i < manager.listLoselements.Count; i++)
            {
                manager.listLoselements[i].transform.localScale = new Vector3(manager.rate, manager.rate, manager.rate);
            }


            manager.youLose.enabled = true;


            if (manager.rate > 1)
            {

                manager.activescale = false;
            }

        }
    }
}
