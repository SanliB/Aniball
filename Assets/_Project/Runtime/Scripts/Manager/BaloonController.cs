using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaloonController : MonoBehaviour
{
    public GameObject patlama;
    Skor oyunKontrolScripti;

    void Start()
    {
        oyunKontrolScripti = GameObject.Find("Scripts").GetComponent<Skor>();
    }

    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;

        Destroy(this.gameObject);
        Destroy(go, 0.36f);

        oyunKontrolScripti.BalonEkle();

    }
    void Update()
    {
        
    }
}
