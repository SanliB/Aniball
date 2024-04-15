using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class BaloonManager : MonoBehaviour
{
   
    public GameObject [] balon;
    float balonOlusturmaSuresi = 1f;
    public int balonSayisi = 0;
    public GameObject patlama;
    Score balonPatlama;
    public int balonhizi;
    //public GameObject[] Animations;
    public List<GameObject> Animations;
    public GameObject GameOverPanel;

    void Start()
    {
        balonPatlama = this.gameObject.GetComponent<Score>();
        StartCoroutine(CreatedBalloon());

    }

    void Update()
    {
       
    }

    IEnumerator CreatedBalloon()
    {
        while (true)
        {
            if (balonSayisi >=0 && balonSayisi <10)
            {
                GameObject go = Instantiate(balon[Random.Range(0, 7)], new Vector2(Random.Range(-2f, 2f), -5f), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, balonhizi));
                balonSayisi++;
              
            }

            else if (balonSayisi == 10)
            {
                //GameObject[] Animations; /*= GameObject.FindGameObjectsWithTag("Animation");*/
                GameObject[] go = GameObject.FindGameObjectsWithTag("Balonlar");
                for (int i = 0; i < go.Length; i++)
                {

                    Animations[i]=Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                    Destroy(go[i]);
                    Destroy(Animations[i], 0.36f);

                    GameOverPanel.SetActive(true);

                }
            }

            yield return new WaitForSeconds(balonOlusturmaSuresi);

        }
    }
}
