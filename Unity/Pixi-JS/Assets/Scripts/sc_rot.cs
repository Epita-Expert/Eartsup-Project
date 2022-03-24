using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_rot : MonoBehaviour
{
    [Header("Shape")]
    [SerializeField] float rotationSpeed = 100f;
    Rigidbody rb_my;
    bool dragging = false;
    bool b_original;
    public GameObject go_original;
    

    [Space,Header("Verify")]
    public GameObject go_verify;
    public Rigidbody rb_shadow;
    public bool b_Verify;

    private void Start()
    {
        rb_my = GetComponent<Rigidbody>();
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

        if (dragging && !b_Verify)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;
            rb_my.AddTorque(Vector3.down * x);
            rb_my.AddTorque(Vector3.right * y);
        }

        if(dragging && b_Verify)
        {
            print(this.gameObject.name);
            gameObject.transform.rotation = go_verify.transform.rotation;
        }
    }
}