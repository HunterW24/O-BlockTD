using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverScreen;
   
    void Start()
    {
        
    }

    void Update()
    {
        if (Health.health <= 0 && gameOverScreen.activeInHierarchy == false)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
