using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{

    public void Easy()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        CarController.moveSpeed = 4f; 
    }

    public void Medium()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        CarController.moveSpeed = 5.5f; 
    }

    public void Hard()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        CarController.moveSpeed = 6.5f; 
    }
}
