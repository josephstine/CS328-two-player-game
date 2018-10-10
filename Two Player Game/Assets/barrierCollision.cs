using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierCollision : MonoBehaviour {

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
        if ((obj.gameObject.name == "bullet2(Clone)"|| obj.gameObject.name == "bullet1(Clone)") && GameControl.instance.b1 == 0)
        {
            barrier.transform.position = new Vector2(100f, 100f);
            Destroy(obj.gameObject);
            GameControl.instance.b1Text.text = "";
            destroyed = true;
        }
        else if(obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.b1TakesDamage();
            Destroy(obj.gameObject);
        }
        

    }

    void respawnBarrier()
    {
        Renderer rd = GetComponent<Renderer>();
        barrier.transform.position = new Vector2(-5.4f, 4);
        GameControl.instance.b1Text.text = "5";
        GameControl.instance.b1 = 5;
        destroyed = false;
        timer = 0;
    }
}
