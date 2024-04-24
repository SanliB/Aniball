using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class BaloonManager : MonoBehaviour
{
   
    public GameObject [] balloon;
    float balloonCreationTime = 1f;
    public int balloonQuantity = 0;
    public GameObject animation;
    Score burstBalloon;
    public int balloonSpeed;
    //public GameObject[] Animations;
    public List<GameObject> Animations;
    public GameObject GameOverPanel;

    void Start()
    {
        burstBalloon = this.gameObject.GetComponent<Score>();
        StartCoroutine(CreatedBalloon());

    }

    void Update()
    {
       
    }

    IEnumerator CreatedBalloon()
    {
        while (true)
        {
            if (balloonQuantity >= 0 && balloonQuantity < 10)
            {
                GameObject go = Instantiate(balloon[Random.Range(0, 7)], new Vector2(Random.Range(-2f, 2f), -5f), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, balloonSpeed));
                balloonQuantity++;
              
            }

            else if (balloonQuantity == 10)
            {
                //GameObject[] Animations; /*= GameObject.FindGameObjectsWithTag("Animation");*/
                GameObject[] go = GameObject.FindGameObjectsWithTag("Balloons");
                for (int i = 0; i < go.Length; i++)
                {

                    Animations[i]=Instantiate(animation, go[i].transform.position, go[i].transform.rotation);
                    Destroy(go[i]);
                    Destroy(Animations[i], 0.36f);

                    GameOverPanel.SetActive(true);

                }
            }

            yield return new WaitForSeconds(balloonCreationTime);

        }
    }
}
