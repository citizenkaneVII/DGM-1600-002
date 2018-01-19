using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guesser : MonoBehaviour {

		public int max;
		private int maxsave;
		public int min;
		private int minsave;
		public int guess;
		public int count;
		private int countsave;


	// Use this for initialization
	private void Start () 
	{
		max = max + 1;
		maxsave = max;
		minsave = min;
		countsave = count;

		print ("Welcome to Number Guesser, dingus.");
		print ("Pick a number between " + min + " and " + max);
		
		//Is the value NextGuess
		NextGuess();

		//Instructions - Push these buttons
		print ("Press Up arrow for higher, Down arrow for lower, Enter for correct.  Think you got that?");
	}



	//NextGuess function
	private void NextGuess()
	{
		count = count - 1; //Count - 1
		//figure out how to randomize guess********************
		guess = (min + max) / 2;
		print ("Is the number " + guess + "?");
	}
	


	//Reset function
	private void Restart()
	{
				max = maxsave;
				min = minsave;
				count = countsave;
				Start();
	}



	// Update is called once per frame
	public void Update () 
	{

		if (count == 0)
		{
			print("You Suck! I Hate You! YOU Win...");
		}

		else if (guess == 666)
		{
			print ("Hail Satan.");
		}

		//Down Arrow command
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}


		//Up Arrow command
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}


		//Enter command
		else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
		{	
			print("HA HA LOSER, I WIN!");
			print("Press R to play again, dweb?");
			
		}

		else if (Input.GetKeyDown(KeyCode.R))
		{
			Restart();
		}

	}




}
