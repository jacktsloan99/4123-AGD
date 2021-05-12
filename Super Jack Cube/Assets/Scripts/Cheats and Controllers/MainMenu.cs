using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This code was adapted from Brackeys on YouTube
//Video: https://www.youtube.com/watch?v=zc8ac_qUXQY
public class MainMenu : MonoBehaviour
{
    public void PlayGame() {

        SceneManager.LoadScene("Level_1");
    }
    public void QuitGame()
    {
        Debug.Log("Quit was successful");
        Application.Quit();
    }
}
