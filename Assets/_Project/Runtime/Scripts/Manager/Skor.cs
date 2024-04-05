using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Skor : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int patlayanBalon;
    public BaloonManager manager;

    void Start()
    {
        score.text = "" + patlayanBalon;
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        score.text = "" + patlayanBalon;
        manager.balonhizi += 5;
    }
}
