using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Objective01 : MonoBehaviour {

	public GameObject TheObject;
	public int CloseObjective;

	void Update () {
		if (CloseObjective == 1){
			if (TheObjective.transform.localScale.y <= 0.0f){
				CloseObjective = 0;
				TheObjective.SetActive (false);
			}
			else {
				TheObjective.transform.localScale.y -= new Vecotr3 (0.0f, 0.01f, 0.0f);
			}
		}
	}

	void onTriggerEnter(){
		StartCoroutine (FinishObjective());
	}

	IEnumerator FinishObjective(){
		TheObjective.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		CloseObjective = 1;

	}

}
