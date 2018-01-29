using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	public Text text;
	private States myState;
	private enum States 
	public Text textObject;
	public Text titleObject;


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
		else if (myState == States.look_0)			{state_look_0 ();}
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
		textObject.title =  "The Legend of BOOTS"
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
	
	
	void state_exposition_1 () {
		textObject.text	 =	"The two older brothers would chop wood in the forest so they could sell it. " +
							"One day when a troll scared them away, Boots decided to go into the forest. \n\n " +
							"Press SPACE to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.exposition_2;}
		}


	void state_exposition_2 () {
		text.text = 		"You are given a bag with some bread, cheese, and a knife.   " +
							"You march out into the forest.  A fork lies in front of you.   " +
							"Do you go left or right?\n\n" +
							"Press L to go LEFT "+
							"Press R to go RIGHT";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.left;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.right;}
		}
	
	
	void state_right () {
		text.text = 		"You reach a dead end.  Brush and trees surround you with no end in sight.\n\n" +
							"Press F to go back to the FORK";
		if 		(Input.GetKeyDown(KeyCode.F))		{myState = States.fork;}
		}
	
	
	void state_fork () {
		text.text = 		"A Fork lies in front of you.  Do you go left or right?\n\n" +
							"Press L to go LEFT "+
							"Press R to go RIGHT";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.left;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.right;}
		}
	
	
	void state_left () {
		text.text = 		"You reach the clearing where your brother's have chopped wood. \n\n " +
							"Press L to Look around,";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.look;}
		}
	
	
	void state_look () {
		text.text = 		"As you walk among the tree stumps, you  see a large foot print in the ground. " +
							"You hear a loud CRUNCH.  Looking up, you see a large Troll carrying a great ax.\n\n" +
							"'I'm goin' ta' eat ya!!' he roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}


void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

	
	void state_runaway () {
		text.text = 		"You attempt to run away but before you even get the chance to turn around, " +
							"the Troll picks you up with his massive hands and bites off your head!\n\n" +
							"Press Space to Start Over";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.title;}
		}		
			

	void state_runaway_0 () {
		text.text =			"You run as he stuffs his face.  Unfortunately, the bread is not enough. " +
							"He begins to chase after you.\n\n" +
							"R to RUN home"
							"H to HIDE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.slaughter;}
		else if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.hide;}
		}		
		
	void state_bread () {
		text.text = 		"You pull out the bread your father gave you.  It's a bit moldy, but maybe the troll won't mind?\n\n" +
							"O to OFFER" +
							"W to WITHDRAW";
		if 		(Input.GetKeyDown(KeyCode.O))		{myState = States.offer;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.look_0;}
		}								
									
										
	void state_offer () {
		text.text = 		"You offer him the moldy bread.  Quickly he snatches it from you, shoving it in his filthy face. \n\n" +
							"R to RUNAWAY"+
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.knife_0;}
		}											
												
													
	void state_knife () {
		text.text = 		"You attempt to stab him in an all out attack.  Before you can stab him, " +
							"he picks you up in one swipe and bites your head off.\n\n" +
							"GAME OVER\n\n"
							"Press SPACE to Restart";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.Title;}
		}																									
																																																		
		
	void state_knife_0 () {
		text.text = 		"You manage to stab the Troll in the knee.  He howls with pain. \n\n" +
							"S to keep STABBING him"+
							"R to RUNAWAY";
		if 		(Input.GetKeyDown(KeyCode.S))		{myState = States.knife;}
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.runaway_0;}
		}															
		
		
	void state_hide () {
		text.text = 		"You hide behind some bushes.  He stops nearby in a grove, screaming \n\n" +
							"'I'm goin' kill you boy!!!'\n\n" +
							"He continues to look for you, but he can't find you.  Eventually, he gives up. " +
							"It's safe to come out. \n\n"  +
							"H to go HOME";
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = vagabond;}
		}											
		
		
	void state_vagabond () {
		text.text = 		"You make it home, but it's clear that you can't go back in the woods.  You and your family" +
							"are forced to leave the woods and become vagabonds.\n\n" +
							"GAME OVER \n\n" +
							"Press SPACE to restart";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.title;}
		}																																																													
	
	
	void state_slaughter () {
		text.text = 		"You run all the way home, but your speed couldn't outmatch his giant leaps.  As you run into your house, " +
							"the Troll runs at it and smashes the thing to pieces. You and your entire family is slaughtered.\n\n" +
							"GAME OVER \n\n" +
							"Press SPACE to Restart";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.title;}
		}		
	
	
	void state_cheese () {
		text.text = 		"You pull out the cheese.  The Troll looks at it.\n\n"
							"'Oi! What's that you got there boy?' he snarls.\n\n"
							"O to OFFER" +
							"L to LIE" +
							"T to THROW";
		if 		(Input.GetKeyDown(KeyCode.O))		{myState = States.offer_0;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lie;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.throw;}		
		}

		void state_offer_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}

		void state_look_0 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n"
							"What do you do?\n\n"
							"R to RUNAWAY" +
							"B to use BREAD" +
							"C to use CHEESE" +
							"K to use KNIFE";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife;}			
		}
	
	
	
	
	
	
}