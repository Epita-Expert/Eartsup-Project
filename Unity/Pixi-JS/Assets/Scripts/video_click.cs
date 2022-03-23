using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class video_click : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoplayer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Playvideo());
    }

    IEnumerator Playvideo()
    {
        videoplayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(0);
        while (!videoplayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoplayer.texture;
        videoplayer.Play();
        
    }
}

