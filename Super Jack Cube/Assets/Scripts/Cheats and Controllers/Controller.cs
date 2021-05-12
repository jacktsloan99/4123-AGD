using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F5))//Level 1
        {
            SceneManager.LoadScene("Level_1");
        }
        else if (Input.GetKey(KeyCode.F6))//Level 2
        {
            SceneManager.LoadScene("Level_2");
        }
        else if (Input.GetKey(KeyCode.F7))// Level 3
        {
            SceneManager.LoadScene("Level_3");
        }
        else if (Input.GetKey(KeyCode.F8))// Cube Movement
        {
            Debug.LogWarning("Cube Movement Not implemented");
        }
    }
}
