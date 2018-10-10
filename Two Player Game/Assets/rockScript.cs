using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rockScript : MonoBehaviour {
    int speed = 2;

    // Use this for initialization
    void Start () { 
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.player1Scored();
            Destroy(gameObject);
            Destroy(obj.gameObject);
        }

        if (obj.gameObject.name == "bullet2(Clone)")
        {
            GameControl.instance.player2Scored();
            Destroy(gameObject);
            Destroy(obj.gameObject);
        }

    }
}
