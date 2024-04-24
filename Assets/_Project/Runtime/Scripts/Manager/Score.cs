using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int burstBalloon;
    public BaloonManager manager;

    void Start()
    {
        score.text = "" + burstBalloon;
    }

    public void CreatedBalloon()
    {
        burstBalloon += 1;
        score.text = "" + burstBalloon;
        manager.balloonSpeed += 5;
        manager.balloonQuantity--;
    }

}
