using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_rotate : MonoBehaviour
{
    Vector3 v3_prevpos = Vector3.zero;
    Vector3 v3_PosDelta = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            v3_PosDelta = Input.mousePosition - v3_prevpos;
            if(Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(v3_PosDelta,Camera.main.transform.right), Space.World);
                
            }
            else
            {
                transform.Rotate(transform.up, Vector3.Dot(v3_PosDelta, Camera.main.transform.right), Space.World);
            }
        }

        v3_prevpos = Input.mousePosition;

    }
}
