using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int health;
	public Sprite [] sprites;

	public void Awake()
	{
		GameManager.brickCount++;
		print(GameManager.brickCount);
		GetComponent<SpriteRenderer>().sprite = sprites[0];
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		health--;
		GetComponent<SpriteRenderer>().sprite = sprites[health];


		if (health <= 0)
		{
			Destroy (gameObject);
			GameManager.brickCount--;
			print(GameManager.brickCount);
			if(GameManager.brickCount == 0)
			{
				FindObjectOfType<GameManager>().LoadNextLevel();
			}
		}
	}
}
