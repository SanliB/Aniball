using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static volatile T _instance = null;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }

    }
    public void OnDestroy()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
    }
}