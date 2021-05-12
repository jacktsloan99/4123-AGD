using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    //Variables
    public int count;
    public int score = 5;
    public string levelName;
    void Start()
    {
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        //Takes stock of the coin count
        if (other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            //count = count + score;
            Score.scoreValue += score;

        }
        if (other.gameObject.CompareTag("OoB"))
        {
            SceneManager.LoadScene(levelName);
        }
        
        if (other.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    
}

