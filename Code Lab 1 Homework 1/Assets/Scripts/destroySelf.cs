using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySelf : MonoBehaviour {
    public GameObject bullet;

	// Use this for initialization
	void Start () {

        Invoke("Destroy", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Destroy()
    {
        Destroy(bullet);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Invoke("Destory", 0.5f);
    }
}
