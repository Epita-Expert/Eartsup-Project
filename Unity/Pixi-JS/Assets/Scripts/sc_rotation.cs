using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_rotation : MonoBehaviour
{
    Vector2 v2_turn;
    public float f_sensitiv = 0.5f;
    public float f_speed = 1f;
    public Vector3 v3_delta;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        v2_turn.x += Input.GetAxis("Mouse X") * f_sensitiv;
        v2_turn.x += Input.GetAxis("Mouse Y") * f_sensitiv;
        this.gameObject.transform.localRotation = Quaternion.Euler(0, v2_turn.x, 0);
        transform.localRotation = Quaternion.Euler(-v2_turn.y, 0,0);
    }
}