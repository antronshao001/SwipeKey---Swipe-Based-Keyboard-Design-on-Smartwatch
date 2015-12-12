using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swipeFive : MonoBehaviour {
	
	public FlickGesture flick;// Use this for initialization
	public TapGesture tap;
	public InputField intext;
	public int buttonNumber;
	private const float tweenDuration = 0.03f;
	private const float tweenScale = 1.2f;
	private const float offset = 0.2f;
	
	void Start () {
		HOTween.Init ();
		flick.Flicked += HandleFlick;
		tap.Tapped += HandleTapped;
		//intext = GameObject.Find ("InputField").GetComponentsInChildren<Text>()[1];
		intext = GameObject.Find ("theText").GetComponent<InputField>();
		
	}
	
	void HandleTapped (object sender, System.EventArgs e)
	{
		switch (buttonNumber) {
		case 1:
			intext.text += "e";
			buttonAnimation(4,"e");
			break;
		case 2:
			intext.text += "i";
			buttonAnimation(4,"i");
			break;
		case 3:
			intext.text += "o";
			buttonAnimation(4,"o");
			break;
		case 4:
			intext.text += "t";
			buttonAnimation(4,"t");
			break;
		case 5:
			intext.text += "y";
			buttonAnimation(4,"y");
			break;
		case 6:
			intext.text += "z";
			buttonAnimation(4,"z");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void HandleFlick(object sender, System.EventArgs e){
		switch (buttonNumber) 
		{
		case 1:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "c";
					buttonAnimation(0,"c");}
				else{	//left swipe
					intext.text += "a";
					buttonAnimation(1,"a");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "b";
					buttonAnimation(2,"b");}
				else{	//down swipe
					intext.text += "d";
					buttonAnimation(3,"d");}
			}
			break;
		case 2:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "h";
					buttonAnimation(0,"h");}
				else{	//left swipe
					intext.text += "f";
					buttonAnimation(1,"f");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "g";
					buttonAnimation(2,"g");}
				else{	//down swipe
					intext.text += "j";
					buttonAnimation(3,"j");}
			}
			break;
		case 3:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "m";
					buttonAnimation(0,"m");
				}
				else{	//left swipe
					intext.text += "k";
					buttonAnimation(1,"k");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "l";
					buttonAnimation(2,"l");}
				else{	//down swipe
					intext.text += "n";
					buttonAnimation(3,"n");}
			}
			break;
		case 4:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "r";
					buttonAnimation(0,"r");}
				else{	//left swipe
					intext.text += "p";
					buttonAnimation(1,"p");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "q";
					buttonAnimation(2,"q");}
				else{	//down swipe
					intext.text += "s";
					buttonAnimation(3,"s");}
			}
			break;
		case 5:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "w";
					buttonAnimation(0,"w");}
				else{	//left swipe
					intext.text += "u";
					buttonAnimation(1,"u");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "v";
					buttonAnimation(2,"v");}
				else{	//down swipe
					intext.text += "x";
					buttonAnimation(3,"x");}
			}
			break;
		case 6:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					// intext.text += " ";
					buttonAnimation(0," ");}
				else{	//left swipe
					// if(intext.text.Length > 0)
					// 	intext.text = intext.text.Remove (intext.text.Length - 1);
					buttonAnimation(1,"");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += ",";
					buttonAnimation(2,",");}
				else{	//down swipe
					intext.text += ".";
					buttonAnimation(3,".");}
			}
			break;
		}
		
	}
	
	void buttonAnimation(int dir,string note){
		Vector3 oScale = transform.localScale;
		Vector3 oPosition = transform.position;
		Sequence buttonSequence = new Sequence ();
		buttonSequence.Append(HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("localScale", oScale * tweenScale)));
		buttonSequence.Append(HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("localScale", oScale)));
		switch(dir){
		case 0:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x+offset,oPosition.y,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		case 1:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x-offset,oPosition.y,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		case 2:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x,oPosition.y+offset,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		case 3:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x,oPosition.y-offset,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		default:
			break;
		}
		buttonSequence.Play ();
	}
	
}
