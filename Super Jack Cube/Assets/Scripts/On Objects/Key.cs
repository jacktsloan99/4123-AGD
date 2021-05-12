using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    public string color = "Purple";
    void Start()
    {
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            //Set up to destroy the gate so the player can go through it
            Destroy(GameObject.Find(color + " Gate"));
            //Set up to destroy any multiples of the gates
            Destroy(GameObject.Find(color + " Gate (1)"));
            Destroy(GameObject.Find(color + " Gate (2)"));
        }

    }
}
