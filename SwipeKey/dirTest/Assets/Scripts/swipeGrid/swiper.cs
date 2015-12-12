using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;

public class swiper : MonoBehaviour {
	
	public TapGesture tap;
	public FlickGesture flick;
	public int swiperID;
	public int inputID;
	public watcher theWatch;
	public GameObject[] arrow;
	
	// Use this for initialization
	void Start () {
		HOTween.Init ();
		tap.Tapped += HandleTapped;
		flick.Flicked += HandleFlicked;
	}

	void HandleFlicked (object sender, System.EventArgs e)
	{
		if (theWatch.start) {
			theWatch.checkSwipe (swiperID * theWatch.inputPerBut + swipeNumber ());} 
		else {theWatch.start = true;}
	}	
	
	// Update is called once per frame
	void Update () {
		//arrow [1].GetComponentInChildren<Renderer> ().material.color = Color.red;
		//Color.red;
	}
	
	void HandleTapped (object sender, System.EventArgs e)
	{
		if (theWatch.start && (theWatch.inputPerBut % 2 == 1) ) {
			theWatch.checkSwipe (swiperID * theWatch.inputPerBut);} 
		else {theWatch.start = true;}
	}

	int swipeNumber(){
		switch (theWatch.inputPerBut) {
		case 2:
			if(flick.ScreenFlickVector.x > 0)
				return 0;
			else
				return 1;
		case 3:
			if(flick.ScreenFlickVector.x > 0)
				return 1;
			else
				return 2;
		case 4:
			if(Mathf.Abs(flick.ScreenFlickVector.x)>Mathf.Abs(flick.ScreenFlickVector.y) ){
				if(flick.ScreenFlickVector.x > 0)
					return 0;
				else
					return 2;
			}
			else{
				if(flick.ScreenFlickVector.y > 0)
					return 3;
				else
					return 1;
			}
		case 5:
			if(Mathf.Abs(flick.ScreenFlickVector.x)>Mathf.Abs(flick.ScreenFlickVector.y) ){
				if(flick.ScreenFlickVector.x > 0)
					return 1;
				else
					return 3;
			}
			else{
				if(flick.ScreenFlickVector.y > 0)
					return 4;
				else
					return 2;
			}
		case 6:
			if(flick.ScreenFlickVector.x>0){
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs (flick.ScreenFlickVector.y)*1.7320508){
					return 0;}
				else if(flick.ScreenFlickVector.y>0){
					return 5;}
				else{
					return 1;}
			}
			else{
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs (flick.ScreenFlickVector.y)*1.7320508){
					return 3;}
				else if(flick.ScreenFlickVector.y>0){
					return 4;}
				else{
					return 2;}
			}
		case 7:
			if(flick.ScreenFlickVector.x>0){
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs (flick.ScreenFlickVector.y)*1.7320508){
					return 1;}
				else if(flick.ScreenFlickVector.y>0){
					return 6;}
				else{
					return 2;}
			}
			else{
				if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs (flick.ScreenFlickVector.y)*1.7320508){
					return 4;}
				else if(flick.ScreenFlickVector.y>0){
					return 5;}
				else{
					return 3;}
			}
		case 8:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					return 0;}
				else{	//left swipe
					return 4;}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					return 6;}
				else{	//down swipe
					return 2;}
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					return 7;}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					return 1;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					return 5;}
				else {	//left-down
					return 3;}
			}
		case 9:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.41421356 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					return 1;}
				else{	//left swipe
					return 5;}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 2.41421356 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.y > 0){	//up swipe
					return 7;}
				else{	//down swipe
					return 3;}
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					return 8;}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					return 2;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					return 6;}
				else {	//left-down
					return 4;}
			}
		case 10:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.324919696 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					return 0;}
				else{	//left swipe
					return 5;}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 1.37638192 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.x > 0 && flick.ScreenFlickVector.y >0){	//up-right swipe
					return 8;}
				else if(flick.ScreenFlickVector.x > 0 && flick.ScreenFlickVector.y <0){	//down-right swipe
					return 2;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y <0){	//down-left swipe
					return 3;}
				else{	//up-left
					return 7;}

			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					return 9;}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					return 1;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					return 6;}
				else {	//left-down
					return 4;}
			}
		case 11:
			if(Mathf.Abs(flick.ScreenFlickVector.x) * 0.324919696 > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
				if(flick.ScreenFlickVector.x > 0){	//right swipe
					return 1;}
				else{	//left swipe
					return 6;}
			}
			else if(Mathf.Abs(flick.ScreenFlickVector.x) * 1.37638192 < Mathf.Abs(flick.ScreenFlickVector.y)){	//up/down swipe
				if(flick.ScreenFlickVector.x > 0 && flick.ScreenFlickVector.y >0){	//up-right swipe
					return 9;}
				else if(flick.ScreenFlickVector.x > 0 && flick.ScreenFlickVector.y <0){	//down-right swipe
					return 3;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y <0){	//down-left swipe
					return 4;}
				else{	//up-left
					return 8;}
				
			}
			else{							//left/right-up/down
				if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y >= 0){	//right-up
					return 10;}
				else if(flick.ScreenFlickVector.x >= 0 && flick.ScreenFlickVector.y < 0){	//right-down
					return 2;}
				else if(flick.ScreenFlickVector.x < 0 && flick.ScreenFlickVector.y >= 0){	//left-up
					return 7;}
				else {	//left-down
					return 5;}
			}
		}
		return 100;
	}

}
