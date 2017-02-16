using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm : MonoBehaviour {

	public const int HP_MIN = 0;
	public const int HP_MAX = 10;

	private static int hp;

	GameObject lch;

	public int Hp
	{
		get
		{ 
			return hp;
		}

		set
		{ 
			hp = value;

			if (hp > HP_MAX)
			{
				hp = HP_MAX;
			}

			if (hp < HP_MIN)
			{
				hp = HP_MIN;
			}
		}

	}

	public static gm instance;

	void Start () 
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad (this);
			//DontDestroyOnLoad (lch);

		} else 
		{
			Destroy (gameObject);
		}


		hp = 10;

		lch = GameObject.Find ("ch");
	}
	

	void Update () 
	{
		print ("HP: " + hp);

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			SceneManager.LoadScene("2");
		}
	}

	void reducelife()
	{
		hp -= 1;
	}
}
