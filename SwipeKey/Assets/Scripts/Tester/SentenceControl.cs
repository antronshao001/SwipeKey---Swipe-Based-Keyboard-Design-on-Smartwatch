using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Text;
using System.IO;

public class SentenceControl : MonoBehaviour {


	public Text timeText;
	public Text sentence;
	public Text cnumber;
	const int lineNum = 500;
	public float timer;
	public bool stopFlag;
	public string[] line = new string[lineNum];
	string fileName = "/Users/anthony/SwipeKey/Assets/phrases2.txt";
	// Use this for initialization
	void Start () {
		timer = 0.0f;
		stopFlag = true;
		try{
			StreamReader theReader = new StreamReader(fileName, Encoding.Default);
			using(theReader){
				for(int i=0;i<lineNum;i++){
					line[i] = theReader.ReadLine();
				}

			}
		}
		catch {
			Debug.Log("Error");
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(!stopFlag){
			timer += Time.deltaTime;
			timeText.text = "Time: "+timer.ToString()+"s";
		}
	}


}
