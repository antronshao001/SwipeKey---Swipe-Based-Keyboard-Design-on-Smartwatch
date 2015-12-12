using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class touchThree : MonoBehaviour {
	
	public TapGesture tap;
	public Vector3 oPosition;
	public Vector3 oScale;
	public swipeBoard theBoard;
	public int keyNumb;
	public InputField intext;
	public swipeBoardKey board;

	// Use this for initialization
	void Start () {
		HOTween.Init ();
		oPosition = transform.parent.gameObject.transform.position;
		oScale = transform.parent.gameObject.transform.localScale;
		tap.Tapped += HandleTapped;
		intext = GameObject.Find ("theText").GetComponent<InputField> ();
	}

	void HandleTapped (object sender, System.EventArgs e)
	{
		if (theBoard.zoomIn) {
			switch(keyNumb){
			case 1:
				intext.text += "q";
				backToScreen();
				break;
			case 2:
				intext.text += "w";
				backToScreen();
				break;
			case 3:
				intext.text += "e";
				backToScreen();
				break;
			case 4:
				intext.text += "r";
				backToScreen();
				break;
			case 5:
				intext.text += "t";
				backToScreen();
				break;
			case 6:
				intext.text += "y";
				backToScreen();
				break;
			case 7:
				intext.text += "u";
				backToScreen();
				break;
			case 8:
				intext.text += "i";
				backToScreen();
				break;
			case 9:
				intext.text += "o";
				backToScreen();
				break;
			case 10:
				intext.text += "p";
				backToScreen();
				break;
			case 11:
				intext.text += "a";
				backToScreen();
				break;
			case 12:
				intext.text += "s";
				backToScreen();
				break;
			case 13:
				intext.text += "d";
				backToScreen();
				break;
			case 14:
				intext.text += "f";
				backToScreen();
				break;
			case 15:
				intext.text += "g";
				backToScreen();
				break;
			case 16:
				intext.text += "h";
				backToScreen();
				break;
			case 17:
				intext.text += "j";
				backToScreen();
				break;
			case 18:
				intext.text += "k";
				backToScreen();
				break;
			case 19:
				intext.text += "l";
				backToScreen();
				break;
			case 20:
				intext.text += "z";
				backToScreen();
				break;
			case 21:
				intext.text += "x";
				backToScreen();
				break;
			case 22:
				intext.text += "c";
				backToScreen();
				break;
			case 23:
				intext.text += "v";
				backToScreen();
				break;
			case 24:
				intext.text += "b";
				backToScreen();
				break;
			case 25:
				intext.text += "n";
				backToScreen();
				break;
			case 26:
				intext.text += "m";
				backToScreen();
				break;
			case 27:
				intext.text += ",";
				backToScreen();
				break;
			case 28:
				intext.text += ".";
				backToScreen();
				break;
			}	
		
		}	
	}
	// Update is called once per frame
	void Update () {
	
	}

	void backToScreen(){
		transform.parent.gameObject.transform.position = oPosition;
		transform.parent.gameObject.transform.localScale = oScale;
		board.transform.position = new Vector3(0.0f,-1.1f,0.0f);
		theBoard.zoomIn = false;
	}

}
