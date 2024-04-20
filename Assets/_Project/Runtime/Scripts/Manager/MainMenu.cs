using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Music;
    public GameObject SettingsPanel;
    public void Start()
    {
        BackgroundMusic.Instance.backgroundMusic.Play();
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
