using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_ch : MonoBehaviour {

	GameObject lget;
	GameObject lch;
	GameObject lthrone_left;

	bool  isSameStep;

	public float Rspeed;

	float movespeed;

	float speed_myPlanet;

	void Start () 
	{
		lget = GameObject.Find ("get");
		lch = GameObject.Find ("ch");
		lthrone_left = GameObject.Find ("throne_left");

		isSameStep = false;

		movespeed = 0.01f;

		speed_myPlanet = 0.01f;


	}
	

	void Update () 
	{
		if (isSameStep)
		{
			//lget.transform.position = new Vector3 (lch.transform.position.x,lch.transform.position.y, lch.transform.position.z) ;
			transform.Rotate( 0 ,0, Rspeed);
		}

		float x = transform.position.x;
		float y = transform.position.y;


		x += 0.01f;



		if (Input.GetKey (KeyCode.UpArrow)) 
		{			
			print ("up");
			y += 0.05f;
			transform.position = new Vector3 (transform.position.x,y,0);
		} 
		if (Input.GetKey (KeyCode.DownArrow)) 
		{			
			y -= 0.05f;
			transform.position = new Vector3 (transform.position.x,y,0);
		} 

		if (Input.GetKey (KeyCode.RightArrow)) 
		{			
			print ("right");
			x += 0.05f;
			transform.position = new Vector3 (x,transform.position.y,0);
		} 
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{			
			print ("left");
			x -= 0.05f;
			transform.position = new Vector3 (x,transform.position.y,0);
		} 


//		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		pz.z = 0;
//
//		transform.Translate (pz * speed_myPlanet);	
			
	}


	void OnTriggerEnter2D (Collider2D co)
	{
		Debug.Log ("collide");
		if (co.name == "get") 
		{
			Debug.Log ("meet! and GETTING");
			lthrone_left.transform.SetParent(transform);
			lthrone_left.transform.localPosition = new Vector3 (-0.74f, -0.02f, 0);

			isSameStep = true;
		}
	}


//	void OnTriggerEnter2D (Collider2D collider)
//	{
//		Debug.Log ("collide !");
//		//name_Meet = collider.name;
//		//Debug.Log ("name_Meet : " + name_Meet);
//	}
}
