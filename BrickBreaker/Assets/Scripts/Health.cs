using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	private void OnCollisionEnter2D(Collision2D other)
	{
		health--;
		if (health <= 0)
		{
			Destroy (gameObject);
		}
	}
}
