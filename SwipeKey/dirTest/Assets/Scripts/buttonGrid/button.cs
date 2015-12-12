using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class button : MonoBehaviour {

	public TapGesture tap;
	public int buttonID;
	public watch theWatch;


	// Use this for initialization
	void Start () {
		HOTween.Init ();
		tap.Tapped += HandleTapped;
	}	

	// Update is called once per frame
	void Update () {

	}

	void HandleTapped (object sender, System.EventArgs e)
	{
		if (theWatch.start) {
						theWatch.checkTap (buttonID);} 
		else {theWatch.start = true;}
	}
}
