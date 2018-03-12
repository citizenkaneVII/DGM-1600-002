using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

public int health;
public int GameObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	



	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.log("collided");
		health--;
			
		if(health <= 0)
		{
			//die
			//play death particle
			Instantiate(deathParticle);
			//destroy this game object
			Destory(gameObject);
		}
	}
}

