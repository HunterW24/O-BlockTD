using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OBlock : MonoBehaviour
{
    public GameObject towerDefense;
    public GameObject oBlock;
    public int highscore;
    public Button button;
    public bool isButtonEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isButtonEnabled = ScoreManager.highscore >= highscore;
        button.interactable = isButtonEnabled;
    }

    private void Switch()
    {
        towerDefense.SetActive(true);
        oBlock.SetActive(false);
    }

    private void change()
    {
        towerDefense.SetActive(false);
        oBlock.SetActive(true);
    }
}
