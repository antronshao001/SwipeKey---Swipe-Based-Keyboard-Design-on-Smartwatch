using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Holoville.HOTween;

public class watch : MonoBehaviour {
	
	public button[] buttonList;
	public int tapNum;
	public int correctTap;
	public Color highlight;
	public Color regular;
	public bool start;
	public bool waitTap;
	private int theID;
	public Text textStatus;
	private float timer = 60.0f;
	public SpriteRenderer watchBG;

	// Use this for initialization
	void Start () {
		start = false;
		waitTap = false;
		tapNum = 0;
		correctTap = 0;
		textStatus.text = "Tap to start";
		HOTween.Init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (start) {
			timer -= Time.deltaTime;
			string tail = ((int)timer).ToString();
			if(timer <= 0){
				tail = tapNum.ToString () + " swipes per minute";
				start = false;}
			textStatus.text = "Score:\n" + correctTap.ToString () + " out of " + tapNum.ToString () + "\n"
					+ ((float)correctTap/(float)tapNum).ToString () + "%\nTime: " + tail;
		}
		if (start && !waitTap) {
			turnOnButton(Random.Range(0,buttonList.Length));
			waitTap = true;}
	}

	void turnOnButton(int buttonNumber)
	{
		theID = buttonNumber;
		button theButton = buttonList [buttonNumber];
		theButton.renderer.material.color = highlight;
	}

	public void checkTap(int buttonID){
		if (start && waitTap) {
			if(buttonID == theID){
				tapNum+=1;
				correctTap+=1;
			}
			else{
				tapNum+=1;
				Sequence warning = new Sequence();
				warning.Append(HOTween.To (watchBG,0.05f,new TweenParms().Prop("color",Color.red)));
				warning.Insert(0.05f,HOTween.To (watchBG,0.05f,new TweenParms().Prop("color",Color.white)));
				warning.Play();
			}
			buttonList[theID].renderer.material.color = regular;
		}
		waitTap = false;
	}

}
