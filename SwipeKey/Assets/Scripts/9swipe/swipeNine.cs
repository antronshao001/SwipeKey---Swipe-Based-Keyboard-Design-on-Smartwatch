using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swipeNine: MonoBehaviour {
	
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
		tap.Tapped += HandleTap;
		//intext = GameObject.Find ("InputField").GetComponentsInChildren<Text>()[1];
		intext = GameObject.Find ("theText").GetComponent<InputField>();
		
	}

	void HandleTap (object sender, System.EventArgs e)
	{
		switch (buttonNumber) {
			case 1:
				intext.text += "e";
				buttonAnimation(0,"e");
				break;
			case 2:
				intext.text += "n";
				buttonAnimation(0,"n");
				break;
			case 3:
				intext.text += "w";
				buttonAnimation(0,"w");
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
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "f";
					buttonAnimation(0,"f");}
				else{	//left swipe
					intext.text += "d";
					buttonAnimation(1,"d");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "b";
					buttonAnimation(2,"b");}
				else{	//down swipe
					intext.text += "h";
					buttonAnimation(3,"h");}
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					intext.text += "c";
					buttonAnimation(4,"c");}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					intext.text += "i";
					buttonAnimation(5,"i");}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					intext.text += "a";
					buttonAnimation(6,"a");}
				else {	//left-down
					intext.text += "g";
					buttonAnimation(7,"g");}
			}
			break;
		case 2:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "o";
					buttonAnimation(0,"o");}
				else{	//left swipe
					intext.text += "m";
					buttonAnimation(1,"m");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "k";
					buttonAnimation(2,"k");}
				else{	//down swipe
					intext.text += "q";
					buttonAnimation(3,"q");}
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					intext.text += "l";
					buttonAnimation(4,"l");}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					intext.text += "r";
					buttonAnimation(5,"r");}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					intext.text += "j";
					buttonAnimation(6,"j");}
				else {	//left-down
					intext.text += "p";
					buttonAnimation(7,"p");}
			}
			break;
		case 3:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += "x";
					buttonAnimation(0,"x");}
				else{	//left swipe
					intext.text += "v";
					buttonAnimation(1,"v");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "t";
					buttonAnimation(2,"t");}
				else{	//down swipe
					intext.text += "z";
					buttonAnimation(3,"z");}
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					intext.text += "u";
					buttonAnimation(4,"u");}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					intext.text += ".";
					buttonAnimation(5,".");}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					intext.text += "s";
					buttonAnimation(6,"s");}
				else {	//left-down
					intext.text += "y";
					buttonAnimation(7,"y");}
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
		}
		buttonSequence.Play ();
	}
	
}
