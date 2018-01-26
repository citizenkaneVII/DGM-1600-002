using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	public Text text;
	private States myState;
	private enum States 
	public Text textObject;


	{
		title,
		exposition0,
		exposition1,
		exposition 2
		right,
		left,
		fork,
		look,
		runaway,
		runaway0,
		bread,
		offer,
		offer0,
		knife,
		knife0,
		slaughter,
		hide,
		vagabond,
		cheese,
		lie,
		magicgem/dragonturd,
		throw,
		stone,
		squeeze,
		gold,
		cut,
		never,
		ax,
	};
	
	
	
	// Use this for initialization
	void Start () {
		myState = States.title;
	
	}
	
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.title) 			{state_title ();} 
		else if (myState == States.exposition_0)	{state_exposition_0 ();} 
		else if (myState == States.exposition_1) 	{state_exposition_1 ();}
		else if (myState == States.exposition_2)	{state_exposition_2 ();}
		else if (myState == States.cell_right)		{state_right ();}
		else if (myState == States.left)			{state_left ();}
		else if (myState == States.fork)			{state_fork ();}
		else if (myState == States.look)			{state_look ();}
		else if (myState == States.runaway_0)		{state_runaway ();}
		else if (myState == States.runaway_0)		{state_runaway_0 ();}	
		else if (myState == States.bread)			{state_bread ();}	
		else if (myState == States.offer)			{state_offer ();}	
		else if (myState == States.offer_0)			{state_offer_0 ();}	
		else if (myState == States.knife)			{state_knife ();}	
		else if (myState == States.knife_0)			{state_knife_0 ();}		
		else if (myState == States.slaughter)		{state_slaughter ();}	
		else if (myState == States.hide)			{state_hide ();}	
		else if (myState == States.vagabond)		{state_vagabond ();}
		else if (myState == States.cheese)			{state_cheese ();}
		else if (myState == States.lie)				{state_lie ();}
		else if (myState == States.magicgem_turd)	{state_magicgem_turd ();}
		else if (myState == States.throw)			{state_throw ();}
		else if (myState == States.squeeze)			{state_squeeze ();}
		else if (myState == States.gold)			{state_gold ();}
		else if (myState == States.cut)				{state_cut ();}
		else if (myState == States.never)			{state_never ();}
		else if (myState == States.ax)				{state_ax ();}
		}
	
	
	
	void state_title ()
		{
		textObject.text = 	"The Legend of BOOTS" +
							"Press SPACE to Start" +
		if 		(Input.GetKeyDown(KeyCode.Space)) 	{myState = States.exposition_0;} 
		}
	
	
	void state_exposition_0 () {
		textObject.text	 = 	"Once upon a time, a poor widowed farmer owed a lot of money to the king. " +
							"He had three sons.  The two older sons made fun of the youngest son named Boots. \n\n" +
							"Press SPACE to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space)) 	{myState = States.exposition_1;}
		}
	
	
	void state_exposition_2 () {
		textObject.text	 =	"The two older brothers would chop wood in the forest so they could sell it. " +
							"One day when a troll scared them away, Boots decided to go into the forest. \n\n " +
							"Press SPACE to Continue";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
		}


	void state_mirror () {
		text.text = "You see your worn face and you question what has brought you here. " +
					"To think this all started when you refused to walk grandmother's monkey. " +
					"On another note, it seems you can remove this mirror from the wall.\n\n" +
					"Press T to Take mirror, press R to Return to roaming your cell";
		if 		(Input.GetKeyDown(KeyCode.T))	{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
		}
	
	
	void state_cell_mirror () {
		text.text = "You stand in your cell holding the mirror.\n\n" +
					"Press S to view Sheets, press L to view Lock";
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_1;}
		}
	
	
	void state_sheets_1 () {
		text.text = "You can't use a freaking mirror on your bed, how would that even work?\n\n" +
					"Press R to Return to roaming your cell";
		if 		(Input.GetKeyDown (KeyCode.R))	{myState = States.cell_mirror;}
		}
	
	
	void state_lock_1 () {
		text.text = "Man, whoever locked you up in here must of been high, cause you can totally " +
					"see which buttons he was pressing!\n\n" +
					"Press O to Open the lock, press R to Return to roaming your cell";
		if 		(Input.GetKeyDown(KeyCode.O))		{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_mirror;}
		}
	
	
	void state_freedom () {
		text.text = "HAHA!!  SUCKERS!!!  You're home free now!  All you gotta do is get out of here!\n\n" +
					"Press P to Play again!";
		if 		(Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}			
		}

	
	void state_corridor_0 () {
		text.text = "HAHA!  Man, who ever made that lock was a freaking tard!  You're out of your " +
					"prison cell, but make a wrong move and it'll be back to the slammer.\n\n" +
					"Press S to go up the Stairs, press C to open the closet, press F to examine floor";
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor;}
		}		
			
		
	void state_stairs_0 () {
		text.text = "A guard waits at the top.  Upon seeing you, he sighs before cracking his knuckles. " +
					"You picked the wrong day buddy.\n\n" +
					"Press F to Fight, press R to Retreat";
		if 		(Input.GetKeyDown(KeyCode.F))	{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
		}								
									
										
	void state_closet_door () {
		text.text = "It's locked, what did you think was going to happen? \n\n" +
					"Press R to Return to the corridor";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_0;}
		}											
												
													
	void state_floor () {
		text.text = "For some reason, stairing at your shoes seems like a good idea. Looking " +
					"down, you notice a hairclip on the floor.\n\n" +
					"Press H to pick up the Hairclip, press L to Leave it";
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.corridor_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.corridor_0;}
		}																									
																																																		
		
	void state_corridor_1 () {
		text.text = "Good job, you have a hair clip, now what? \n\n" +
					"Press S to go up the Stairs, press P to Pick the closet lock";
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.in_closet;}
		}															
		
		
	void state_in_closet () {
		text.text = "You unlocked the closet door.  You see a janitors uniform hanging" +
					"inside.\n\n" +
					"Press D to Dress, press L to Leave it";
		if 		(Input.GetKeyDown(KeyCode.D))	{myState = States.corridor_3;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.corridor_0;}
		}											
		
																												
	void state_corridor_2 () {
		text.text = "You stand in the hall like a ding-dong.\n\n  " +
			"Press S to go up the Stairs, press C to open the closet";
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.in_closet;}
		}
		
		
	void state_corridor_3 () {
		text.text = "You look like a proper janitor now!  \n\n" +
					"Press U to Undress, press S to go up the stairs";
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.corridor_2;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_2;}
		}																																																													
	
	
	void state_stairs_2 () {
		text.text = "You ascend the stairs.  You see the guard standing in front of a door. " +
					"He gives you a look of bad attitude.  Otherwise, he dosen't seem to care.\n\n" +
					"Press F to Fight him, press E to Exit through the door";
		if 		(Input.GetKeyDown(KeyCode.F))	{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.E)) 	{myState = States.courtyard;}
		}		
	
	
	void state_courtyard () {
		text.text = "You did it!  You escaped this heck hole and are on your way to  " +
					"freedom!  Horay for no cosequences!  So long suckas!\n\n" +
					"Press P to Play again";
		if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.cell;}
		}		
	
	
	
	
	
	
	
	
	
}