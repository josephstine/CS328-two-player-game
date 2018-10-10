using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    int speed = 20;
	// Use this for initialization
	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
        //transform.Translate(Vector3.right * speed * Time.deltaTime);

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
