using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class operation : MonoBehaviour {
	
	public FlickGesture flick;// Use this for initialization
	public InputField intext;
	void Start () {
		flick.Flicked += HandleFlick;
		//intext = GameObject.Find ("InputField").GetComponentsInChildren<Text>()[1];
		intext = GameObject.Find ("theText").GetComponent<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void HandleFlick(object sender, System.EventArgs e){
		if(Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){	//right/left swipe
			if(flick.ScreenFlickVector.x > 0){	//right swipe
				intext.text += "\n";//
				Debug.Log("right"+intext.text);
			}
			else{	//left swipe
				intext.text = intext.text.Remove(intext.text.Length-1);//
				Debug.Log("left"+intext.text.Length);
			}
		}
		else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
			if(flick.ScreenFlickVector.y > 0){	//up swipe
				intext.text += " ";//
				Debug.Log("up"+intext.text);
			}
			else{	//down swipe
				intext.text += "k";//
				Debug.Log("down"+intext.text);
			}
		}
	}
}
