using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_WinCondition : MonoBehaviour
{
    [Space, Header("Probes")]
    [Space]
    public Collision tr_verifiShadowForward;
    public Collision tr_verifiShadowBackward;

    [Space,Header("References Object")]
    public Collider col_Forward;
    public Collider col_Backward;

    [Space, Header("Confirm Bool")]
    public bool b_win;


    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        if(b_win)
        {
            StartCoroutine("win");
        }
        
    }
   

    IEnumerator win()
    {
        print("FINIS");
        b_win = false;
        yield return b_win;
    }
}


