using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {

	public static int HealthValue;
	public int InternalHealth;
	public GameObject Heart01;
	public GameObject Heart02;
	public GameObject Heart03;

	// Use this for initialization
	void Start () {
		HealthValue = 1;
	}
	
	// Update is called once per frame
	void Update () {
		InternalHealth = HealthValue;

		if(HealthValue == 1){
			Heart01.SetActive (true);
		}
		if(HealthValue == 2){
			Heart02.SetActive (true);
		}
		if(HealthValue == 3){
			Heart03.SetActive (true);
		}



	}
}
