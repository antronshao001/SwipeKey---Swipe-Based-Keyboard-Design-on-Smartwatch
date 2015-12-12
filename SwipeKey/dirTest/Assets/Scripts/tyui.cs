using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tyui : MonoBehaviour {

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
				intext.text += "u";//
				Debug.Log("right"+intext.text);
			}
			else{	//left swipe
				intext.text += "t";//
				Debug.Log("left"+intext.text);
			}
		}
		else if(Mathf.Abs(flick.ScreenFlickVector.y) > Mathf.Abs(flick.ScreenFlickVector.x)){	//up/down swipe
			if(flick.ScreenFlickVector.y > 0){	//up swipe
				intext.text += "y";//
				Debug.Log("up"+intext.text);
			}
			else{	//down swipe
				intext.text += "i";//
				Debug.Log("down"+intext.text);
			}
		}
	}
}
