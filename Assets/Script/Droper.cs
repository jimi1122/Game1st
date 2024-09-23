using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigidbody;
    [SerializeField] float downTime = 5f;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        
        render.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > downTime)
        {
            // Debug.Log("DONE DOWN");
            rigidbody.useGravity = true;
            
            render.enabled = true;
            

        }
        // Debug.Log(Time.time);
    }
}
