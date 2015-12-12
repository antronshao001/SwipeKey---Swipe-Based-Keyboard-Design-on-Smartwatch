using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;


public class ChangeScene : MonoBehaviour {

	public Text button;
	public SentenceControl control;

	// Use this for initialization
	void Start(){


	}

	public void changeScene () {
		if(control.stopFlag){
			control.sentence.text = control.line[Random.Range(0,500)];
			control.cnumber.text = "C#: "+control.sentence.text.Length.ToString();
			control.timer = 0.0f;			
			button.text = "Stop";
			control.stopFlag = false;		
		}
		else{
			button.text = "ChangeScene";
			control.stopFlag = true;
		}
	}


}
