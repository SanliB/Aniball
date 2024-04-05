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
    float balonSayisi = 0f;
    public GameObject patlama;
    Skor balonPatlama;
    public int balonhizi;


    void Start()
    {
        balonPatlama = this.gameObject.GetComponent<Skor>();
       
    }

    void Update()
    {
        
        balonSayisi -= Time.deltaTime;

        if (balonSayisi<=0 && balonPatlama.patlayanBalon>=0)
        {
            GameObject go = Instantiate(balon[Random.Range(0, 7)], new Vector2(Random.Range(-2f, 2f), -5f), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, balonhizi));


            balonSayisi = balonOlusturmaSuresi;
        }
        
        /*else
        {
                GameObject[] go = GameObject.FindGameObjectsWithTag("Balonlar");
                for (int i = 0; i < go.Length; i++)
                {

                    Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                    Destroy(go[i]);
                }
        }*/
    }
    
}
