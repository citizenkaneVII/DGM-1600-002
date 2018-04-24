using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Button : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject Noticecam;
	public GameObject UIQuest;
	public GameObject ActiviveQuestBox;
	public GameObject Objective01;
	public GameObject Objective02;
	public GameObject Objective03;

	public void AcceptQuest () {
		ThePlayer.SetActive (true);
		Noticecam.SetActive (false);
		UIQuest.SetActive (false);
		StartCoroutine (SetQuestUI());
	}

	IEnumerator SetQuestUI () {
		ActiviveQuestBox.GetComponent <Text>().text = "My First Weapon";
		Objective01.GetComponent <Text>().text = "Reach the clearing in the woods";
		Objective02.GetComponent <Text>().text = "Open the chest";
		Objective03.GetComponent <Text>().text = "Retrieve the weapon";
		QuestManager.ActiveQuestNumber = 1;
		yield return new WaitForSeconds(0.5f);
		ActiviveQuestBox.SetActive (true);
		yield return new WaitForSeconds(1);
		Objective01.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		Objective02.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		Objective03.SetActive (true);
		yield return new WaitForSeconds(9);
		ActiviveQuestBox.SetActive (false);
		Objective01.SetActive (false);
		Objective02.SetActive (false);
		Objective03.SetActive (false);
	}

	public void DeclineQuest () {
		ThePlayer.SetActive (true);
		Noticecam.SetActive (false);
		UIQuest.SetActive (false);
	}
}
