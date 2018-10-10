using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player1Script : MonoBehaviour {

    public GameObject bullet;
    int speed = 10;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)&&transform.position.y<4)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)&& transform.position.y > -4)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(bullet, transform.TransformPoint(Vector3.right * 2), transform.rotation);
        }
		
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "bullet2(Clone)" && GameControl.instance.health1 == 0)
        {
            Destroy(gameObject);
            Destroy(obj.gameObject);
            GameControl.instance.shipDied();
        }
        else if (obj.gameObject.name == "bullet2(Clone)")
        {
            GameControl.instance.player1TakesDamage();
            Destroy(obj.gameObject);
        }

    }
}
