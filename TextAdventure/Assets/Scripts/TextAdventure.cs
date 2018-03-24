using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	public Text titleObject;
	public Text text;
	public Image backgroundImageObject;
	public Image foregroundImageObject;
	public Sprite [] backgroundImages;
	public Sprite [] foregroundImages;
	private States myState;
	private int GameManager;


	private enum States 
		{
			homescreen,
			exposition_0,
			exposition_1,
			exposition_2,
			right,
			left,
			fork,
			look_0,
			look_1,
			runaway_0,
			runaway_1,
			bread,
			offer_0,
			offer_1,
			knife_0,
			knife_1,
			slaughter,
			hide,
			vagabond,
			cheese,
			lie,
			magicgem_dragonturd,
			throw_it,
			stone,
			squeeze,
			gold,
			cut,
			never,
			axe,
		};
	

	
	// Use this for initialization
	void Start () {
		myState = States.homescreen;
		backgroundImageObject.sprite = backgroundImages[0];
	}
	
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.homescreen) 			{state_homescreen ();} 
		else if (myState == States.exposition_0)		{state_exposition_0 ();} 
		else if (myState == States.exposition_1) 		{state_exposition_1 ();}
		else if (myState == States.exposition_2)		{state_exposition_2 ();}
		else if (myState == States.right)				{state_right ();}
		else if (myState == States.left)				{state_left ();}
		else if (myState == States.fork)				{state_fork ();}
		else if (myState == States.look_0)				{state_look_0 ();}
		else if (myState == States.look_1)				{state_look_1 ();}
		else if (myState == States.runaway_0)			{state_runaway_0 ();}
		else if (myState == States.runaway_1)			{state_runaway_1 ();}	
		else if (myState == States.bread)				{state_bread ();}	
		else if (myState == States.offer_0)				{state_offer_0  ();}	
		else if (myState == States.offer_1)				{state_offer_1 ();}	
		else if (myState == States.knife_0)				{state_knife_0 ();}	
		else if (myState == States.knife_1)				{state_knife_1 ();}		
		else if (myState == States.slaughter)			{state_slaughter ();}	
		else if (myState == States.hide)				{state_hide ();}	
		else if (myState == States.vagabond)			{state_vagabond ();}
		else if (myState == States.cheese)				{state_cheese ();}
		else if (myState == States.lie)					{state_lie ();}
		else if (myState == States.magicgem_dragonturd)	{state_magicgem_dragonturd ();}
		else if (myState == States.throw_it)			{state_throw_it ();}
		else if (myState == States.stone)				{state_stone ();}
		else if (myState == States.squeeze)				{state_squeeze ();}
		else if (myState == States.gold)				{state_gold ();}
		else if (myState == States.cut)					{state_cut ();}
		else if (myState == States.never)				{state_never ();}
		else if (myState == States.axe)					{state_axe ();}
		}


	private void state_homescreen () {
		backgroundImageObject.sprite = backgroundImages[0];
		foregroundImageObject.sprite = foregroundImages[0];
		titleObject.text = "The Legend Of\n"+
							"BOOTS";
		text.text = "Press SPACE to Start\n"+
					"Q to Quit";			
		if 		(Input.GetKeyDown(KeyCode.Space)) 	{myState = States.exposition_0;}
		else if (Input.GetKeyDown(KeyCode.Q))       {Application.Quit(); Debug.Log("Quit Game");}
		else if (Input.GetKeyDown(KeyCode.Return))	{myState = States.exposition_0;} 
		}
	
	
	void state_exposition_0 () {
		Destroy(titleObject);
		text.text = 		"Once upon a time, a poor widowed farmer owed a lot of money to the king. He had three sons.  "+  
							"The two older sons made fun of the youngest son named Boots.\n\n\n" +
							"Press SPACE to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space)) 	{myState = States.exposition_1;}
		else if (Input.GetKeyDown(KeyCode.Return))	{myState = States.exposition_1;} 
		}
	
	
	void state_exposition_1 () {
		text.text =			"The two older brothers would chop wood in the forest so they could sell it.  "+
							"One day when a troll scared them away, Boots decided to go into the forest.\n\n\n " +
							"Press SPACE to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.exposition_2;}
		else if (Input.GetKeyDown(KeyCode.Return))	{myState = States.exposition_2;} 
		}


	void state_exposition_2 () {
		backgroundImageObject.sprite = backgroundImages[3];
		text.text = 		"You are given a bag with some bread, cheese, and a knife.  " +
							"You march out into the forest.  A fork lies in front of you.\n\n" +
							"Do you go left or right?\n\n\n" +
							"Press L to go LEFT \n"+
							"Press R to go RIGHT";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.left;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.right;}
		}
	
	
	void state_right () {
		backgroundImageObject.sprite = backgroundImages[2];
		text.text = 		"You reach a dead end.  Brush and trees surround you with no end in sight.\n\n\n" +
							"F - Go back to the FORK";
		if 		(Input.GetKeyDown(KeyCode.F))		{myState = States.fork;}
		}
	
	
	void state_fork () {
		backgroundImageObject.sprite = backgroundImages[3];
		text.text = 		"A Fork lies in front of you.  Do you go left or right?\n\n\n" +
							"L - go LEFT \n"+
							"R - go RIGHT";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.left;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.right;}
		}
	
	
	void state_left () {
		backgroundImageObject.sprite = backgroundImages[1];
		text.text = 		"You reach the clearing where your brother's have chopped wood.\n\n\n " +
							"L - LOOK around,";
		if 		(Input.GetKeyDown(KeyCode.L))		{myState = States.look_0;}
		}
	
	
	void state_look_0 () {
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"As you walk among the tree stumps, you  see a large foot print in the ground.  "+
							"You hear a loud CRUNCH.  Looking up, you see a large Troll carrying a great ax.\n\n" +
							"'I'm goin' ta' eat ya!!' he roars.\n\n" +
							"What do you do?\n\n\n" +
							"R - RUNAWAY\n" +
							"B - Use BREAD\n" +
							"C - Use CHEESE\n" +
							"K - Use KNIFE\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}			
		}


	void state_look_1 () {
		text.text = 		"'I'm goin' ta' eat ya!!' the Troll roars.\n\n" +
							"What do you do?\n\n\n" +
							"R - RUNAWAY\n" +
							"B - Use BREAD\n" +
							"C - Use CHEESE\n" +
							"K - Use KNIFE\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bread;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cheese;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}			
		}

	
	void state_runaway_0 () {
		backgroundImageObject.sprite = backgroundImages[4];
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"You attempt to run away but before you even get the chance to turn around, " +
							"the Troll picks you up with his massive hands and bites off your head!\n\n" +
							"GAME OVER\n\n\n" +
							"Press Space to Start Over";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.homescreen;}
		}		
			

	void state_runaway_1 () {
		backgroundImageObject.sprite = backgroundImages[3];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text =			"You run as he stuffs his face.  Unfortunately, the bread is not enough. " +
							"He begins to chase after you.\n\n\n" +
							"R - RUN home\n" +
							"H - HIDE\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.slaughter;}
		else if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.hide;}
		}		
		
	void state_bread () {
		text.text = 		"You pull out the bread your father gave you.  It's a bit moldy, but maybe the troll won't mind?\n\n\n" +
							"O - OFFER\n" +
							"W - WITHDRAW\n";
		if 		(Input.GetKeyDown(KeyCode.O))		{myState = States.offer_0;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.look_1;}
		}								
									
										
	void state_offer_0 () {
		text.text = 		"You offer him the moldy bread.  Quickly he snatches it from you, shoving it in his filthy face.\n\n\n" +
							"R - RUNAWAY\n"+
							"K - Use KNIFE\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_1;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}
		}											
												
													
	void state_knife_0 () {
		backgroundImageObject.sprite = backgroundImages[4];
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"You attempt to stab him in an all out attack.  Before you can stab him, " +
							"he picks you up in one swipe and bites your head off.\n\n" +
							"GAME OVER\n\n\n"+
							"Press SPACE to Restart";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.homescreen;}
		}																									
																																																		
		
	void state_knife_1 () {
		text.text = 		"You manage to stab the Troll in the knee.  He howls with pain.\n\n\n" +
							"S - Keep STABBING him\n"+
							"R - RUNAWAY\n";
		if 		(Input.GetKeyDown(KeyCode.S))		{myState = States.knife_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.runaway_0;}
		}															
		
		
	void state_hide () {
		backgroundImageObject.sprite = backgroundImages[3];
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"You hide behind some bushes.  He stops nearby in a grove, screaming \n\n" +
							"'I'm goin' kill you boy!!!'\n\n" +
							"He continues to look for you, but he can't find you.  Eventually, he gives up. " +
							"It's safe to come out.\n\n\n"  +
							"H - go HOME";
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.vagabond;}
		}											
		
		
	void state_vagabond () {
		backgroundImageObject.sprite = backgroundImages[7];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text = 		"You make it home, but it's clear that you can't go back in the woods.  You and your family " +
							"are forced to leave the woods and become vagabonds.\n\n" +
							"GAME OVER \n\n\n" +
							"Press SPACE to restart";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.homescreen;}
		}																																																													
	
	
	void state_slaughter () {
		backgroundImageObject.sprite = backgroundImages[0];
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"You run all the way home, but your speed couldn't outmatch his giant leaps.  As you run into your house, " +
							"the Troll runs at it and smashes the thing to pieces. You and your entire family is slaughtered.\n\n" +
							"GAME OVER \n\n\n" +
							"Press SPACE to Restart";
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.homescreen;}
		}		
	
	
	void state_cheese () {
		foregroundImageObject.sprite = foregroundImages[2];
		text.text = 		"You pull out the cheese.  The Troll looks at it.\n\n" +
							"'Oi! What's that you got there boy?' he snarls.\n\n\n" +
							"O - OFFER\n" +
							"L - LIE\n" +
							"T - THROW\n";
		if 		(Input.GetKeyDown(KeyCode.O))		{myState = States.offer_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lie;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.throw_it;}		
		}

	
	void state_offer_1 () {
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"'It's cheese.  Would you like some?'\n\n" +
							"Despite your best intentions, the Troll spits,\n\n" +
							"'I HATE stinkin' cheese!!!' \n\n" +
							"Realizing you have few options left, you look in your bag.\n\n\n"+
							"R - RUNAWAY\n" +
							"B - use BREAD\n" +
							"K - use Knife\n";
		if	 	(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.offer_0;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}		
		}


	void state_lie () {
		foregroundImageObject.sprite = foregroundImages[2];
		text.text = 		"You wave the cheese in front of him.\n\n" +
							"'You see this troll?  You see what I got in my hand?'.\n\n" +
							"'WHAT is it?!?' yells the Troll in anger.\n\n\n"+
							"M - 'It's a MAGIC GEM!'\n" +
							"S - 'It's a STONE!'\n" +
							"D - 'It's DRAGON'S TURD!'\n";
		if 		(Input.GetKeyDown(KeyCode.M))		{myState = States.magicgem_dragonturd;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stone;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.magicgem_dragonturd;}		
		}


	void state_magicgem_dragonturd () {
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"'BULLOCKS!!' the Troll shouts.  It looks like he called your bluff.\n\n\n" +
							"R - RUNAWAY\n" +
							"K - Use KNIFE\n" +
							"T - THROW cheese\n"+
							"B - Use BREAD\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_0;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.throw_it;}	
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.offer_0;}	
		}


	void state_throw_it () {
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"You throw the cheese, but it bounces off of him.  Angry, he runs at you.\n\n\n" +
							"R - RUNAWAY\n" +
							"K - Use KNIFE\n";
		if 		(Input.GetKeyDown(KeyCode.R))		{myState = States.runaway_0;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.knife_0;}
		}


	void state_stone () {
		text.text = 		"'It's a STONE!!' you proclaim.\n\n" +
							"'A Stone??' laughs the Troll incredulously.\n\n\n" +
							"T - THROW cheese at him\n"+
							"S - SQUEEZE cheese in you fist\n";
		if 		(Input.GetKeyDown(KeyCode.T))		{myState = States.throw_it;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.squeeze;}
		}


	void state_squeeze () {
		foregroundImageObject.sprite = foregroundImages[1];
		text.text = 		"Whey comes out of the cheese in the form of a milky liquid.  The Troll is confused.\n\n" +
							"'What is this?' asks the Troll, nevousness in his voice.  You shout out:\n\n" +
							"'I am so strong, I can squeeze water from this stone, and I will crush you head unless you-'\n\n\n" +
							"G - '-give me your GOLD!'\n" +
							"C - '-CUT all these trees into wood for me!'\n" +
							"N - '-NEVER come near my family of these woods again!'\n"+
							"A - '-give me your AXE!'\n";
		if 		(Input.GetKeyDown(KeyCode.G))		{myState = States.gold;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.cut;}
		else if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.never;}	
		else if (Input.GetKeyDown(KeyCode.A)) 		{myState = States.axe;}	
		}


	void state_axe () {
		backgroundImageObject.sprite = backgroundImages[6];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text = 		"You order the Troll to give you his Ax and depart forever.  While it's heavy, " +
							"you know getting this ax home is beneficial because it will prove to your brothers " + 
							"that you have conquered the troll with your wit.  You all go back to working in the forest, " +
							"and with the help of the Troll's ax, you are able to quickly pay off your father's debt.\n\n" +
							"THE END\n\n\n" +
							"Press Space to play again";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.homescreen;}
		}


	void state_cut () {		
		backgroundImageObject.sprite = backgroundImages[6];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text = 		"The Troll uses his large ax and cuts all the wood in the clearing.  " +
							"You order him to bring it back to your house.  In exchange, you promise that " +
							"your paths will never cross again.  You sell the wood and pay all of your father's debts.\n\n" +
							"THE END\n\n\n"+
							"Press Space to play again";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.homescreen;}
		}


	void state_never () {
		backgroundImageObject.sprite = backgroundImages[7];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text = 		"You order him to never come into these woods.  While this seems well and good, " +
							"your brother's refuse to believe you and never go into the woods again.  " +
							"Unable to pay your father's debts, you all become vagabonds.\n\n" +
							"GAME OVER\n\n\n"+
							"Press Space to play again";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.homescreen;}
		}

	
	void state_gold () {
		backgroundImageObject.sprite = backgroundImages[7];
		foregroundImageObject.sprite = foregroundImages[0];
		text.text = 		"In fear, he gives you his Gold and departs.  You look in your hands and see that " + 
							"you have enough to pay off your Father's debts.  Returning home, your brothers accuse " +
							"you of being a thief and you are shunned from your house.  You are a lone vagabond.\n\n" +
							"GAME OVER\n\n\n"+
							"Press Space to play again";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.homescreen;}
		}


}