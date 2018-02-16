using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

public static GameManager instance = null;

	void Awake() 
	{
		//singlton
		if (instance == null)		//if instance not assigned
		{
			instance = this;		//then assign instance to this object
		}
		else if (instance != this)
		{
			Destroy(this.gameObject);	//then destroy this object
		}
		DontDestroyOnLoad(this.gameObject);
	}


public void LoadLevel (string level) 
	{
		SceneManager.LoadScene(level);
	}
}
