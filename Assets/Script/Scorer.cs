using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
                    score++;
                    Debug.Log("Total " + score + " score Done");
        }
    }

    
}
