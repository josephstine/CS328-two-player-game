using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier6collision : MonoBehaviour {

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
        if ((obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)") && GameControl.instance.b6 == 0)
        {
            barrier.transform.position = new Vector2(600f, 100f);
            Destroy(obj.gameObject);
            GameControl.instance.b6Text.text = "";
            destroyed = true;
        }
        else if (obj.gameObject.name == "bullet2(Clone)" || obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.b6TakesDamage();
            Destroy(obj.gameObject);
        }

    }

    void respawnBarrier()
    {
        Renderer rd = GetComponent<Renderer>();
        barrier.transform.position = new Vector2(5.4f, -4.1f);
        GameControl.instance.b6Text.text = "5";
        GameControl.instance.b6 = 5;
        destroyed = false;
        timer = 0;
    }
}
