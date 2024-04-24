using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaloonController : MonoBehaviour
{
    public GameObject animation;
    Score scoreControl;

    void Start()
    {
        scoreControl = GameObject.Find("Scripts").GetComponent<Score>();
    }

    void OnMouseDown()
    {
        GameObject go = Instantiate(animation, transform.position, transform.rotation) as GameObject;

        Destroy(this.gameObject);
        Destroy(go, 0.36f);

        scoreControl.CreatedBalloon();

    }
    void Update()
    {
        
    }
}
