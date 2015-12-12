using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swipeThree: MonoBehaviour {
	
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
			intext.text += ";";
			buttonAnimation(0,";");
			break;
		case 2:
			intext.text += "\n";
			buttonAnimation(0,"ent");
			break;
		case 3:
			intext.text += "";
			buttonAnimation(0,"");
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
			if(flick.ScreenFlickVector.x > 0){	//right swipe
					intext.text += ".";
					buttonAnimation(1,".");}
			else{	//left swipe
					intext.text += ",";
					buttonAnimation(2,",");}
			break;
		case 2:
			if(flick.ScreenFlickVector.x > 0){	//right swipe
				intext.text += " ";
				buttonAnimation(2," ");}
			else{	//left swipe
				if(intext.text.Length > 0){
					intext.text = intext.text.Remove(intext.text.Length-1);}
				buttonAnimation(1,"det");
			}
			break;
		case 3:
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
			break;
		case 1:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x+offset,oPosition.y,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		case 2:
			buttonSequence.Insert(0,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", new Vector3(oPosition.x-offset,oPosition.y,oPosition.z))));	
			buttonSequence.Insert(tweenDuration,HOTween.To (transform, tweenDuration, new TweenParms ().Prop ("position", oPosition)));	
			break;
		}
		buttonSequence.Play ();
	}
	
}
