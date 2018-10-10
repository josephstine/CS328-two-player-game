using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier5collision : MonoBehaviour {
    public GameObject barrier;
    bool destroyed = false;
    float timer = 0;

    // Use this for initialization
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
        if ((obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)") && GameControl.instance.b5 == 0)
        {
            barrier.transform.position = new Vector2(500f, 100f);
            Destroy(obj.gameObject);
            GameControl.instance.b5Text.text = "";
            destroyed = true;
        }
        else if (obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.b5TakesDamage();
            Destroy(obj.gameObject);
        }

    }


    void respawnBarrier()
    {
        Renderer rd = GetComponent<Renderer>();
        barrier.transform.position = new Vector2(5.4f, 0);
        GameControl.instance.b5Text.text = "5";
        GameControl.instance.b5 = 5;
        destroyed = false;
        timer = 0;
    }
}
