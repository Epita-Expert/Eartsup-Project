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
        { // this "if" statement seems to be the problem
            sc_wincondition.b_win = true;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Col_Arriere")
        {
            sc_wincondition.b_win = true;
        }
    }
}
