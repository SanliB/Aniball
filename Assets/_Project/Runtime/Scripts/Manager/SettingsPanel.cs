
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel: MonoBehaviour
{
    public GameObject Panel;
    public bool isPaused;
    public Slider MusicSlider;
    public Slider SoundSlider;
    public AudioSource Music;
    public AudioSource Sound;

    public void Awake()
    {
        
    }
    public void Start()
    {
        Music = BackgroundMusic.Instance.backgroundMusic;
        if (!PlayerPrefs.HasKey("Music") && !PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetFloat("Music", 1);
            PlayerPrefs.SetFloat("Sound", 1);
        }
        

    }

    public void Update()
    {
        OnMusicSlider();
        OnSoundSlider();
    }
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
     private void OnMusicSlider()
    {
        float musicValue = PlayerPrefs.GetFloat("Music");
        MusicSlider.value = musicValue;
        Music.volume = musicValue;
    }
    public void MusicSetting()
    {
        Music.volume = MusicSlider.value;
        float musicValue = MusicSlider.value;
        PlayerPrefs.SetFloat("Music", musicValue);
    }

    private void OnSoundSlider()
    {
        float soundValue = PlayerPrefs.GetFloat("Sound");
        SoundSlider.value = soundValue;
        Sound.volume = soundValue;
       
    }

    public void SoundSetting()
    {
        Sound.volume = SoundSlider.value;
        float soundValue = SoundSlider.value;
        PlayerPrefs.SetFloat("Sound", soundValue);
    }
}
