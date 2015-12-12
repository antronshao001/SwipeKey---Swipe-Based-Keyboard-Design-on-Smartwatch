using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlTexter : MonoBehaviour {

	public FlickGesture flick;
	public InputField intext;
	public SwiperBoard theBoard;
	public Text errText;
	public int err;
	// Use this for initialization
	void Start () {
		flick.Flicked += HandleFlicked;
		intext = GameObject.Find ("theText").GetComponent<InputField>();
		err = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void HandleFlicked (object sender, System.EventArgs e){
		if (!theBoard.zoomIn) {
						if (Mathf.Abs (flick.ScreenFlickVector.x) > Mathf.Abs (flick.ScreenFlickVector.y)) {	//right/left swipe
								if (flick.ScreenFlickVector.x > 0) {	//right swipe
										intext.text += " ";
								} else if(intext.text.Length > 0) {	//left swipe
										intext.text = intext.text.Remove (intext.text.Length - 1);
										err += 1;
										errText.text = "Error: "+err.ToString();
								}
						} else if (Mathf.Abs (flick.ScreenFlickVector.y) > Mathf.Abs (flick.ScreenFlickVector.x)) {	//up/down swipe
								if (flick.ScreenFlickVector.y > 0) {	//up swipe
										;
								} else {	//down swipe
										intext.text += "\n";
								}
						}

				}
	}
}
