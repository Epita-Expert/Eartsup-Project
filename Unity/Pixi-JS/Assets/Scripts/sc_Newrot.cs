using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Newrot : MonoBehaviour
{
    float f_speed = 20;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X")*f_speed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*f_speed*Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
    }
}
