using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
     [Header("Sound Gestion")]
     public AudioSource m_AudioSource;
     public GameObject go_mute;
     public GameObject go_playing;
    public bool b_IsPlaying;

    void mute()
    {
        if(b_IsPlaying)
        {
            go_playing.SetActive(true);
            go_mute.SetActive(false);
            m_AudioSource.mute = true;
            b_IsPlaying = false;
        }
       
        if(!b_IsPlaying)
        {
            
            go_playing.SetActive(false);
            go_mute.SetActive(true);
            m_AudioSource.mute = false;
            b_IsPlaying = true ;
        }
        
    }
}
