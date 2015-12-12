using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using Holoville.HOTween;

public class SwiperKey : MonoBehaviour {

	public FlickGesture flick;
	public TapGesture tap;
	public SwiperBoard theBoard;
	public float animationDuration = 0.01f;
	// Use this for initialization
	void Start () {
		HOTween.Init ();
		flick.Flicked += HandleFlicked;
		tap.Tapped += HandleTapped;
	}

	void HandleFlicked (object sender, System.EventArgs e)
	{
		if(!theBoard.zoomIn){

		if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
			if(flick.ScreenFlickVector.x > 0){	//right swipe
				buttonMove(5);}
			else{	//left swipe
				buttonMove(3);}
		}
		else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
			if(flick.ScreenFlickVector.y > 0){	//up swipe
				buttonMove(1);}
			else{	//down swipe
				buttonMove(7);}
		}
		else{							//left/right-up/down
			if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
				buttonMove(2);}
			else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
				buttonMove(8);}
			else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
				buttonMove(0);}
			else {	//left-down
				buttonMove(6);}
			}
		}
	}
	
	void HandleTapped (object sender, System.EventArgs e)
	{
		if (!theBoard.zoomIn) {
			buttonMove(4);	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void buttonMove(int dir){
		theBoard.zoomIn = true;
		Sequence keySequence = new Sequence ();
		keySequence.Append (HOTween.To (theBoard.buttonList [dir].transform, animationDuration, new TweenParms ().Prop ("localScale", new Vector3 (5.3f, 3.0f, 1.0f))));
		keySequence.Insert(0,HOTween.To (theBoard.buttonList [dir].transform, animationDuration, new TweenParms ().Prop ("position", new Vector3 (0.0f, -1.2f, -2.0f))));		
		

		keySequence.Play ();
		transform.position = new Vector3 (transform.position.x, transform.position.y, 10);
	}

}