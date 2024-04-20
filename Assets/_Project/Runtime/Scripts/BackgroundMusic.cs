using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMusic : MonoSingleton<BackgroundMusic>
{
    public AudioSource backgroundMusic;

    public void Awake()
    {
        backgroundMusic = gameObject.GetComponent<AudioSource>();

    }
}
