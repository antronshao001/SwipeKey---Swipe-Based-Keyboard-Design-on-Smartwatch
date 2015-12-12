using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Holoville.HOTween;

public class watcher : MonoBehaviour {
	
	public swiper[] swiperList;
	public int swipeNum;
	public int correctSwipe;
	public Color highlight;
	public Color regular;
	public bool start;
	public bool waitSwipe;
	private int swiperID;
	private int inputID;
	public Text textStatus;
	public int inputPerBut;
	public int inputNum = 2;
	private float timer = 60.0f;
	public SpriteRenderer watchBG;

	void Start () {
		start = false;
		waitSwipe = false;
		swipeNum = 0;
		correctSwipe = 0;
		textStatus.text = "Tap to start";
		HOTween.Init ();
	}

	void Update () {
		if (start) {
			timer -= Time.deltaTime;
			string tail = ((int)timer).ToString();
			if(timer <= 0){
				tail = swipeNum.ToString () + " swipes per minute";
				start = false;}
			textStatus.text = "Score:\n" + correctSwipe.ToString () + " out of " + swipeNum.ToString () + "\n"
				+ ((float)correctSwipe/(float)swipeNum).ToString () + "%\nTime: " + tail;
		}
		if (start && !waitSwipe) {
			turnOnInput(Random.Range(0,inputNum));
			waitSwipe = true;}
	}
	
	void turnOnInput(int inputNumber)
	{
		inputID = inputNumber;
		swiperID = (int)Mathf.Floor( (float)inputNumber / (float)inputPerBut );
		swiper theSwiper = swiperList [swiperID];
		theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Renderer> ().material.color = highlight;
		Vector3 tempPosition = theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Transform> ().position;
		tempPosition.z -= 1;
		theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Transform> ().position = tempPosition;
	}
	
	public void checkSwipe(int checkID){
		if (start && waitSwipe) {
			//Debug.Log("checkID="+checkID+" inputID="+inputID);
			if(checkID == inputID){
				swipeNum+=1;
				correctSwipe+=1;
			}
			else{
				swipeNum += 1;
				Sequence warning = new Sequence();
				warning.Append(HOTween.To (watchBG,0.05f,new TweenParms().Prop("color",Color.red)));
				warning.Insert(0.05f,HOTween.To (watchBG,0.05f,new TweenParms().Prop("color",Color.white)));
				warning.Play();
			}
			swiper theSwiper = swiperList [swiperID];
			theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Renderer> ().material.color = regular;
			Vector3 tempPosition = theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Transform> ().position;
			tempPosition.z += 1;
			theSwiper.arrow [inputID - (swiperID * inputPerBut)].GetComponentInChildren<Transform> ().position = tempPosition;
		}
		waitSwipe = false;
	}
	
}
