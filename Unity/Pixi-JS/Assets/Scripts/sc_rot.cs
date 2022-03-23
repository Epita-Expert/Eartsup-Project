using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_rot : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    Rigidbody rb;
    bool dragging = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void OnMouseDrag()
    {
        dragging = true;
    }

    void Update()
    {
    if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (dragging)
        {
            
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;
            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
        else
        {
            
            rb.velocity = Vector3.zero;
        }
    }
}
