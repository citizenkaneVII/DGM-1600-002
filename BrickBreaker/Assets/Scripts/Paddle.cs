using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	public float verticalOffset;
	//


	void Update ()
	{
		//get currenet paddle position
		Vector3 paddlePosition = new Vector3(0, -5, 10);
		//set verticle off set

		//get mouse position
		float mousePositionInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16 - 8, -8f, 8f);

		//convert mouse position to world space
		//save new position
		paddlePosition.x = mousePositionInBlocks;

		//set this paddle object to saved position	
		this.gameObject.transform.position = paddlePosition;
	}
}
