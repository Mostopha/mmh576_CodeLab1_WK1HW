using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMoveScript : MonoBehaviour {

    public float moveMod;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3
            (
            
             moveMod*( Mathf.PerlinNoise(Time.timeSinceLevelLoad, 0)-0.5f),
             moveMod*(Mathf.PerlinNoise(0, Time.timeSinceLevelLoad)-0.5f),
             
             0));


	}
}
