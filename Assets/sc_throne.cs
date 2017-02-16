using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_throne : MonoBehaviour {

	GameObject lgamemanager;

	void Start () 
	{
		lgamemanager = GameObject.Find ("gamemanager");
	}
	

	void Update () 
	{
		
	}

	void OnTriggerEnter2D (Collider2D co) // ch lose one HP
	{
		if (co.name == "ch") 
		{
			print ("collide with ch");
			//need to code hp
			lgamemanager.SendMessage("reducelife");
		}

	}
}
