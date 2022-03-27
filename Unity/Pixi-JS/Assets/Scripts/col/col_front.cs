using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_front : MonoBehaviour
{
    Collider col_fronter;

    public sc_WinCondition sc_wincondition;

    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == "Col_Arriere")
        { 
            print(collided.gameObject.name);
            sc_wincondition.b_confirm = true;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
       
            print("aurevoir");
            sc_wincondition.b_confirm = false;
        
    }
}
