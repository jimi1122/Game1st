using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.UIElements;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float mainThurust = 100;
    [SerializeField]float rotationThurust = 100;
    Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        ProcessThurust();
        ProcessRotation();
    }

    void ProcessThurust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            // rb.AddRelativeForce(0,0, 0);  //we can write by 3 types
            // rb.AddRelativeForce(Vector3.up);//this way is also run for y direction we can change every type of direction
            rb.AddRelativeForce(Vector3.up * Time.deltaTime * mainThurust);
        }
    }
    
    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationThurust);
        }
            
            else if(Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThurust);
        }
    } 
    void ApplyRotation(float frameThurust)
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * frameThurust);
    }
}
