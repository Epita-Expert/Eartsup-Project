using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_WinCondition : MonoBehaviour
{
   public GameObject go_object;

    [Header("value Temp")]
    public float f_tempRotX;
    public float f_tempRotY;
    public float f_tempRotZ;

    [Space]
    float f_SignX;
    float f_SignY;
    float f_SignZ;

    [Space, Header("Win Conditions")]

    float f_WinConditionX ;
    float f_WinConditionY;
    float f_WinConditionZ;

    //[Space, Header("Game Manager")]
   // public Gamemanager sc_gamemanager;


    [Space]
    bool b_WinX;
    bool b_WinY;
    bool b_WinZ;

    [Space]
    bool b_WinW;

    // Start is called before the first frame update
    void Start()
    {
      //  sc_gamemanager = gameObject.GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        f_SignX =  Mathf.Sign(go_object.transform.rotation.x);
        f_SignY =  Mathf.Sign(go_object.transform.rotation.y);
        f_SignZ =  Mathf.Sign(go_object.transform.rotation.z);

        f_tempRotX = Mathf.Abs(go_object.transform.rotation.x);
        f_tempRotY = Mathf.Abs(go_object.transform.rotation.y);
        f_tempRotZ = Mathf.Abs(go_object.transform.rotation.z);


        //WinCondition sur les Différents axes
        //Win Condition sur l'axe X
        if (Mathf.Approximately(f_WinConditionX, 14f) && f_SignX <= 0)
        { b_WinX = true;}
        else
        { b_WinX = false; }


        //WinCondition sur l'axe Y
        if(Mathf.Approximately(f_WinConditionY,14f) && f_SignY <= 0)
        { b_WinY = true;}
        else
        { b_WinY = false;}


        //WinCondition sur l'axe Z
        if (Mathf.Approximately(f_WinConditionZ, 14f) && f_SignZ <= 0)
        { b_WinZ = true;}
        else
        { b_WinZ = false;}

        //Si toute les conditions sont Bonnes 
        if(b_WinX && b_WinY && b_WinZ)
        { b_WinW = true;} //C'est gagné => Game Manager
    }
}
