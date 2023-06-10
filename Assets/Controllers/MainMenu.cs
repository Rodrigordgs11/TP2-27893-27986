using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Levels");
        //Time.timeScale = 1;
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}