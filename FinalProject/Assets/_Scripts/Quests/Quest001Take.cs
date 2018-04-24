﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject UIQuest;
	public GameObject ThePlayer;
	public GameObject NoticeCam;
	
	// Update is called once per frame
	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			Screen.lockCursor = false;
			Cursor.visible = true;
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if(Input.GetButtonDown ("Action")){
			if (TheDistance <= 3) {
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				UIQuest.SetActive (true);
				NoticeCam.SetActive (true);
				ThePlayer.SetActive (false);
			}

		}

	}

	void OnMouseExit () {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

}
