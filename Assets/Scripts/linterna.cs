using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour
{

    public Light luzLinterna;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Linterna")){
            if((luzLinterna.enabled == true)){

                luzLinterna.enabled = false;

            }else if (luzLinterna.enabled == false){
                luzLinterna.enabled = true;
            }
        }
    }
}
