using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scorereq : MonoBehaviour
{
    public Button button;
    public bool isButtonEnabled = false;

    void Update()
    {
        // Update score as needed

        isButtonEnabled = ScoreManager.score > 0;
        button.interactable = isButtonEnabled;
    }
}
