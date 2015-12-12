using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class SwiperSecond : MonoBehaviour {

	public TapGesture tap;
	public FlickGesture flick;
	public Vector3 oPosition;
	public Vector3 oScale;
	public SwiperBoard theBoard;
	public int buttonNumb;
	public InputField intext;
	public SwiperKey board;

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
				intext.text += "b";
				backToScreen();
				break;
			case 2:
				intext.text += "e";
				backToScreen();
				break;
			case 3:
				intext.text += "h";
				backToScreen();
				break;
			case 4:
				intext.text += "k";
				backToScreen();
				break;
			case 5:
				intext.text += "n";
				backToScreen();
				break;
			case 6:
				intext.text += "q";
				backToScreen();
				break;
			case 7:
				intext.text += "t";
				backToScreen();
				break;
			case 8:
				intext.text += "w";
				backToScreen();
				break;
			case 9:
				intext.text += "z";
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
					intext.text += "c";
				else	//left swipe
					intext.text += "a";
				backToScreen();
				break;
			case 2:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "f";
				else	//left swipe
					intext.text += "d";
				backToScreen();
				break;
			case 3:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "i";
				else	//left swipe
					intext.text += "g";
				backToScreen();
				break;
			case 4:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "l";
				else	//left swipe
					intext.text += "j";
				backToScreen();
				break;
			case 5:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "o";
				else	//left swipe
					intext.text += "m";
				backToScreen();
				break;
			case 6:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "r";
				else	//left swipe
					intext.text += "p";
				backToScreen();
				break;
			case 7:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "u";
				else	//left swipe
					intext.text += "s";
				backToScreen();
				break;
			case 8:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += "x";
				else	//left swipe
					intext.text += "v";
				backToScreen();
				break;
			case 9:
				if(flick.ScreenFlickVector.x > 0)	//right swipe
					intext.text += ".";
				else	//left swipe
					intext.text += "y";
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
