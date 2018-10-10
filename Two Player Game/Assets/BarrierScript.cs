using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "bullet2(Clone)")
        {
            Destroy(gameObject);
        }

    }
}
