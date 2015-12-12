using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swipeButton : MonoBehaviour {
	
	public FlickGesture flick;// Use this for initialization
	public InputField intext;
	public int buttonNumber;
	private const float tweenDuration = 0.03f;
	private const float tweenScale = 1.2f;
	private const float offset = 0.2f;

	void Start () {
		HOTween.Init ();
		flick.Flicked += HandleFlick;
		//intext = GameObject.Find ("InputField").GetComponentsInChildren<Text>()[1];
		intext = GameObject.Find ("theText").GetComponent<InputField>();

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
						intext.text += "g";
						buttonAnimation(0,"g");}
					else{	//left swipe
						intext.text += "e";
						buttonAnimation(1,"e");}
				}
				else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
					if(flick.ScreenFlickVector.y > 0){	//up swipe
						intext.text += "f";
						buttonAnimation(2,"f");}
					else{	//down swipe
						intext.text += "h";
						buttonAnimation(3,"h");}
				}
				break;
			case 3:
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
					if(flick.ScreenFlickVector.x > 0){	//right swipe
						intext.text += "k";
						buttonAnimation(0,"k");
						}
					else{	//left swipe
						intext.text += "i";
						buttonAnimation(1,"i");}
				}
				else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
					if(flick.ScreenFlickVector.y > 0){	//up swipe
						intext.text += "j";
						buttonAnimation(2,"j");}
					else{	//down swipe
						intext.text += "l";
						buttonAnimation(3,"l");}
					}
				break;
			case 4:
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
					if(flick.ScreenFlickVector.x > 0){	//right swipe
						intext.text += "o";
						buttonAnimation(0,"o");}
					else{	//left swipe
						intext.text += "m";
						buttonAnimation(1,"m");}
				}
				else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
					if(flick.ScreenFlickVector.y > 0){	//up swipe
						intext.text += "n";
						buttonAnimation(2,"n");}
					else{	//down swipe
						intext.text += "p";
						buttonAnimation(3,"p");}
				}
				break;
			case 5:
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
					if(flick.ScreenFlickVector.x > 0){	//right swipe
						intext.text += "s";
						buttonAnimation(0,"s");}
					else{	//left swipe
						intext.text += "q";
						buttonAnimation(1,"q");}
				}
				else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
					if(flick.ScreenFlickVector.y > 0){	//up swipe
						intext.text += "r";
						buttonAnimation(2,"r");}
					else{	//down swipe
						intext.text += "t";
						buttonAnimation(3,"t");}
				}
				break;
		case 6:
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
		case 7:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += ".";
					buttonAnimation(0,".");}
				else{	//left swipe
					intext.text += "y";
					buttonAnimation(1,"y");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += ",";
					buttonAnimation(2,",");}
				else{	//down swipe
					intext.text += "z";
					buttonAnimation(3,"z");}
			}
			break;
		case 8:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					// intext.text += " ";
					buttonAnimation(0,"");
					}
				else{	//left swipe
					// if(intext.text.Length > 0)
					// 	intext.text = intext.text.Remove (intext.text.Length - 1);
					buttonAnimation(1,"");}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					intext.text += "";
					buttonAnimation(2,"");}
				else{	//down swipe
					intext.text += "";
					buttonAnimation(3,"");}
			}
			break;
		case 9:
			if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += " ";
					buttonAnimation(0,"spa");}
				else{	//left swipe
					if(intext.text.Length > 0){
						intext.text = intext.text.Remove(intext.text.Length-1);}
					buttonAnimation(1,"det");
				}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					//intext.text += "s";
					//buttonAnimation(2,"cap");
				}
				else{	//down swipe
					intext.text += "\n";
					buttonAnimation(3,"ent");}
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
