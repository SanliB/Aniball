using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Audio;
    public GameObject SettingsPanel;
    public void Start()
    {
        DontDestroyOnLoad(Audio);
    }
    public void Play()
    {
        SceneManager.LoadScene("Launcher");
    }
    public void OnSettingsPanel()
    {
        SettingsPanel.SetActive(true);
    }
    public void CloseSettingsPanel()
    {
        SettingsPanel.SetActive(false);
    }


    
}
