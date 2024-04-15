using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel: MonoBehaviour
{
    public GameObject Panel;
    public bool isPaused;
    public void OnSettingsPanel()
    {
        Panel.SetActive(true);
        if (isPaused==false)
        {
            Time.timeScale = 0f;
            isPaused = true;     
        }
    }

    public void OutSettingsPanel() 
    { 
        Panel.SetActive(false);
        if (isPaused==true) 
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
}
