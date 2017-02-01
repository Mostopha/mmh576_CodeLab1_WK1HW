using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour {

    GameObject goal;

	// Use this for initialization
	void Start () {

        goal = GameObject.Find("Goal");
        
	}
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(goal.transform.position, transform.position) > 4.5f)
        {
            Destroy(gameObject);
        }


	}
}
