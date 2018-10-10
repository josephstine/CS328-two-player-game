using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier2collision : MonoBehaviour {
    // Use this for initialization

    public GameObject barrier;
    bool destroyed = false;
    float timer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if(destroyed==true)
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
        if ((obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)") && GameControl.instance.b2 == 0)
        {
            barrier.transform.position = new Vector2(200f, 100f);
            Destroy(obj.gameObject);
            GameControl.instance.b2Text.text = "";
            destroyed = true;

        }
        else if (obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.b2TakesDamage();
            Destroy(obj.gameObject);
        }


    }

    void respawnBarrier()
    {
        Renderer rd = GetComponent<Renderer>();
        barrier.transform.position = new Vector2(-5.4f, 0);
        GameControl.instance.b2Text.text = "5";
        GameControl.instance.b2 = 5;
        destroyed = false;
        timer = 0;
    }
}
