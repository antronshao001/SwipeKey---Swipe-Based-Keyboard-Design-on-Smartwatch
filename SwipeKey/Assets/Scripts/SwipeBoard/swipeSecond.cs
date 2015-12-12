using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swipeSecond : MonoBehaviour {

	public TapGesture tap;
	public FlickGesture flick;
	public Vector3 oPosition;
	public Vector3 oScale;
	public swipeBoard theBoard;
	public int buttonNumb;
	public InputField intext;
	public swipeBoardKey board;

	// Use this for initialization
	void Start () {
		HOTween.Init ();
		oPosition = transform.position;
		oScale = transform.localScale;
		tap.Tapped += HandleTapped;
		flick.Flicked += HandleFlicked;
		intext = GameObject.Find ("theText").GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void HandleTapped(object sender, System.EventArgs e){
		if (theBoard.zoomIn) {
			switch(buttonNumb){
			case 1:
				intext.text += "w";
				backToScreen();
				break;
			case 2:
				break;
			case 3:
				intext.text += "o";
				backToScreen();
				break;
			case 4:
				intext.text += "s";
				backToScreen();
				break;
			case 5:
				intext.text += "g";
				backToScreen();
				break;
			case 6:
				intext.text += "k";
				backToScreen();
				break;
			case 7:
				intext.text += "x";
				backToScreen();
				break;
			case 8:
				intext.text += "b";
				backToScreen();
				break;
			case 9:
				intext.text += ",";
				backToScreen();
				break;
			}		
		
		}

	}

	void HandleFlicked(object sender, System.EventArgs e){
		if (theBoard.zoomIn) {
			switch(buttonNumb){
			case 1:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "e";
				else	//left swipe
					intext.text += "q";
				backToScreen();
				break;
			case 2:
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y))
						intext.text += "u";
					else 
						intext.text += "y";
					}
				else{	//left swipe
					if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y))
						intext.text += "r";
					else 
						intext.text += "t";
				}
				backToScreen();
				break;
			case 3:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "p";
				else	//left swipe
					intext.text += "i";
				backToScreen();
				break;
			case 4:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "d";
				else	//left swipe
					intext.text += "a";
				backToScreen();
				break;
			case 5:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "h";
				else	//left swipe
					intext.text += "f";
				backToScreen();
				break;
			case 6:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "l";
				else	//left swipe
					intext.text += "j";
				backToScreen();
				break;
			case 7:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "c";
				else	//left swipe
					intext.text += "z";
				backToScreen();
				break;
			case 8:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "n";
				else	//left swipe
					intext.text += "v";
				backToScreen();
				break;
			case 9:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += ".";
				else	//left swipe
					intext.text += "m";
				backToScreen();
				break;
			}		
			
		}


	}

	void backToScreen(){
		transform.position = oPosition;
		transform.localScale = oScale;
		board.transform.position = new Vector3(0.0f,-1.1f,0.0f);
		theBoard.zoomIn = false;
	}
}
