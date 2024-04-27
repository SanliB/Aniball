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

        manager.balloonQuantity--;

        score.text = "" + burstBalloon;

        if (manager.balloonSpeed < 900)
        {
            manager.balloonSpeed += 5;
        }
          
        if (manager.balloonCreationTime >= 0.325f)
        {
            manager.balloonCreationTime -= burstBalloon * 0.0001f;
        }
        
       
    }

}
