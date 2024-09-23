using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hitObject : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
             GetComponent<MeshRenderer>().material.color = Color.red;
             gameObject.tag = "Hit";
        }
        // Debug.Log("Object hit wall");
       
    }
}
