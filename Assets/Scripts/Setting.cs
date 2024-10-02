using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{

    public GameObject settingScreen;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        Time.timeScale = 0;
        settingScreen.SetActive(true);
    }

    public void SettingLeave()
    {
        Time.timeScale = 1;
        settingScreen.SetActive(false);
    }
}
