using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scorereq : MonoBehaviour
{
    public int score = 0;
    public Button button;
    public bool isButtonEnabled = false;

    void Update()
    {
        // Update score as needed

        isButtonEnabled = score >= 10;
        button.interactable = isButtonEnabled;
    }
}
