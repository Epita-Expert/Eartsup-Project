using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class sc_WinCondition : MonoBehaviour
{
    [Space, Header("Probes")]
    [Space]
    public Collision tr_verifiShadowForward;
    public Collision tr_verifiShadowBackward;


    [Space,Header("References Object")]
    public Collider col_Forward;
    public Collider col_Backward;

    [Space, Header("Confirmation")]
    public float f_confirmShadow;
    public float f_confirmFade;


    [Space, Header("Confirm Bool")]
    public bool b_win;
    public bool b_next;
    [Space]
    public int i_numEnigm = 1;
    public int i_numMAX = 5;

    [Space,Header("Animator")]
    public Animator anim_manager;

    [Space, Header("Panneau")]
    public GameObject go_dirieable;
    public GameObject go_loco;
    public GameObject go_robot;

    public AudioSource aud_vic;

    public GameObject star;
    public bool b_confirm;



    // Update is called once per frame
    void Update()
    {
        if(b_confirm)
        {
            f_confirmShadow += Time.deltaTime;
        }
        else
        {
            f_confirmShadow = 0;
        }

        if( f_confirmShadow >= f_confirmFade)
        {
            b_next = true;
            f_confirmShadow = 0;
        }


        if(b_next)
        {
            StartCoroutine("nextEnigme");
        }

        
        if (i_numEnigm >= i_numMAX)
        {
            StartCoroutine("win");
        }


        //Panneau Dirigeable
        if (i_numEnigm != 1)
        {
            go_dirieable.SetActive(false);
        }
        else
        {
            go_dirieable.SetActive(true);
        }

        //Panneau Loco
        if (i_numEnigm != 2)
        {
            go_loco.SetActive(false);
        }
        else
        {
            go_loco.SetActive(true);
        }
        
        //Panneau Robot
        if(i_numEnigm != 3)
        {
            go_robot.SetActive(false);
        }
        else
        {
            go_robot.SetActive(true);
        }

        
    }

    void reload()
    {
        SceneManager.LoadScene("Jonathan");
    }
   
    IEnumerator nextEnigme()
    {
        f_confirmShadow = 0;
        i_numEnigm++;
        aud_vic.Play();

        anim_manager.SetInteger("i_num", i_numEnigm);
        b_confirm = false;
        b_next = false;
        yield return i_numEnigm;
    }

    IEnumerator win()
    {
        star.SetActive(true);
        b_win = false;
        yield return b_win;
    }
}


