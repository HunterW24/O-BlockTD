using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameStartScreen;

    private void Start()
    {
        gameStartScreen = GameObject.FindWithTag("Start");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        gameStartScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void Fullrestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        Time.timeScale = 1;
    }

}
