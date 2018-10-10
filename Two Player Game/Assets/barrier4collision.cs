using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier4collision : MonoBehaviour {

    // Use this for initialization
    public GameObject barrier;
    bool destroyed = false;
    float timer = 0;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (destroyed == true)
        {
            timer += Time.deltaTime;
            if (timer > 5)
            {
                respawnBarrier();
            }

        }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if ((obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)") && GameControl.instance.b4 == 0)
        {
            barrier.transform.position = new Vector2(400f, 100f);
            //Destroy(gameObject);
            Destroy(obj.gameObject);
            GameControl.instance.b4Text.text = "";
            destroyed = true;
        }
        else if (obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.b4TakesDamage();
            Destroy(obj.gameObject);
        }

    }
    void respawnBarrier()
    {
        Renderer rd = GetComponent<Renderer>();
        barrier.transform.position = new Vector2(5.4f, 4);
        GameControl.instance.b4Text.text = "5";
        GameControl.instance.b4 = 5;
        destroyed = false;
        timer = 0;
    }
}

