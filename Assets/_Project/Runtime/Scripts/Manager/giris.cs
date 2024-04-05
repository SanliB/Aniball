using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class giris : MonoBehaviour
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
    public void Settings()
    {
        SettingsPanel.SetActive(true);
    }
    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
    }
}
