using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_monster : MonoBehaviour {

	public float Rspeed;

	void Start () 
	{
		//Rspeed = 2f;
	}

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate( 0 ,0, Rspeed);
	}
}
