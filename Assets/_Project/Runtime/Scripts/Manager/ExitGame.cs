using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject ExitPanel;
    public bool isPaused;

    public void OnExitPanel()
    {
        ExitPanel.SetActive(true);
        if (isPaused == false)
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

    public void OnNoButton()
    {
        ExitPanel.SetActive(false);
        if (isPaused == true)
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
    }

    public void OnYesButton()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
