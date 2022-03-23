using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public sc_WinCondition sc_win;

    // Start is called before the first frame update
    void Start()
    {
        sc_win = gameObject.GetComponent<sc_WinCondition>();

    }

    // Update is called once per frame
    void Update()
    {

       

    }
}
