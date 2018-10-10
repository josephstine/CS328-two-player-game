using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Scripts : MonoBehaviour {

    public GameObject bullet;
    int speed = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Instantiate(bullet, transform.TransformPoint(Vector3.left * 2), Quaternion.identity);
        }

    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "bullet1(Clone)" && GameControl.instance.health2 == 0)
        {
            Destroy(gameObject);
            Destroy(obj.gameObject);
            GameControl.instance.shipDied();
        }
        else if(obj.gameObject.name == "bullet1(Clone)")
        {
            GameControl.instance.player2TakesDamage();
            Destroy(obj.gameObject);
        }

    }
}
