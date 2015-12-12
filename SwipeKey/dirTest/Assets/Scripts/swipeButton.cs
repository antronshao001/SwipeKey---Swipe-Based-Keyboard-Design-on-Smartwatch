using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Holoville.HOTween;


public class swipeButton : MonoBehaviour {
	
	public FlickGesture flick;// Use this for initialization
	public InputField intext;
	public int buttonNumber;
	private const float tweenDuration = 0.05f;
	private const float tweenScale = 1.2f;
	private const float offset = 0.2f;

	private int totalSwipe = -1; // "Tap to start"
	private int totalHit = 0;
	private int currRed = -1;
	private float percent = 0.0f;
	private Text textStatus;
	private bool start = false;

	public int triangleAngle;

	public Triangle36Degree degree36;

	public  bool includeMiddle;

	private float timer = 120.0f;

	void Start () {
		HOTween.Init ();
		flick.Flicked += HandleFlick;
		//intext = GameObject.Find ("InputField").GetComponentsInChildren<Text>()[1];
		intext = GameObject.Find ("theText").GetComponent<InputField>();
		textStatus = GameObject.Find ("Status").GetComponent<Text>();
		textStatus.text = "Tap to start";

	}

	// Update is called once per frame
	void Update () {
		if(start)
			timer -= Time.deltaTime;

		if (timer <= 0) {
			timer = 0;
			textStatus.text = "Results:\n" + totalHit.ToString () + " out of " + totalSwipe.ToString () + "\n"
				+ percent.ToString () + "%\nTime: " + (totalSwipe / 2).ToString () + " swipes per minute";
		}
		else if(!start)
		{
			textStatus.text = "Tap or swipe to start";
		}
		else {
			textStatus.text = "Score:\n" + totalHit.ToString () + " out of " + totalSwipe.ToString () + "\n"
				+ percent.ToString () + "%\nTime: " + ((int)timer).ToString ();
		}
	}

	void HandleFlick(object sender, System.EventArgs e){
		start = true;
		triangleAngle = swipeWatch.triangleDegree;
		includeMiddle = swipeWatch.includeMiddle;
		Debug.Log (triangleAngle);

		float xdir = flick.ScreenFlickVector.x;
		float ydir = flick.ScreenFlickVector.y;
		float slope = ydir / xdir;

		Debug.Log ("x: "+ xdir.ToString () + " y: " + ydir.ToString() + "\nslope: " + slope.ToString());

		bool isHit = false;
		if (currRed != -1) {
			if (triangleAngle == 90) 
				isHit = checkSwipe90 (xdir, ydir, slope);
			else if (triangleAngle == 60)
				isHit = checkSwipe60 (xdir, ydir, slope);

			else if (triangleAngle == 36) 
				isHit = checkSwipe36 (xdir, ydir, slope);
			else
				return;
		}


		if (isHit)
			totalHit++;

		totalSwipe++;
		if (totalSwipe <= 0) {
			percent = 0.0f;
		} else {
			percent = ((float)totalHit / (float)totalSwipe) * 100;
		}



		setRandDirection();
	}


	void setRandDirection()
	{
		int numOfTriangles = 360/triangleAngle;
		Debug.Log (numOfTriangles);

		Color colorWhite = Color.white;
		Color colorRed = Color.red;

		// Make every triangle white
		GameObject triangle;
		for (int i = 0; i < numOfTriangles; i++) {
			triangle = GameObject.Find ("button-" + (i + 2).ToString());
			triangle.renderer.material.color = colorWhite;
		}

		// Make middle button invisible
		Debug.Log (includeMiddle);
		if (includeMiddle) {
			GameObject sphere = GameObject.Find ("button-" + (numOfTriangles + 2).ToString());
			sphere.renderer.enabled = false;
		}


		// Make one red
		int randNum;
		if(includeMiddle)
			randNum = Random.Range (0, numOfTriangles + 1);
		else
			randNum = Random.Range (0, numOfTriangles);

		currRed = randNum + 2;
		Debug.Log ("currRed: " + currRed);
		GameObject triangleRed = GameObject.Find ("button-" + currRed.ToString ());
		triangleRed.renderer.material.color = colorRed;
		if (currRed == numOfTriangles + 2) {
			triangleRed.renderer.enabled = true;
		}
	}


	bool checkSwipe90(float xdir, float ydir, float slope)
	{
		if (Mathf.Abs (xdir) <= 20.0f && Mathf.Abs (ydir) <= 20.0f) { // Middle
			Debug.Log ("Middle");
			if(currRed == 6)
				return true;
		}

		if (Mathf.Abs (xdir) > Mathf.Abs (ydir)) {
			if (xdir > 0) {
				// Button-4
				Debug.Log ("Right");
				if(currRed == 4)
					return true;

				
			} else {
				// Button-2
				Debug.Log ("Left");
				if(currRed == 2)
					return true;

			}
		} else {
			if (ydir > 0) {
				Debug.Log ("Up");
				if(currRed == 5)
					return true;

			} else {
				Debug.Log ("Down");
				if(currRed == 3)
					return true;

			}
		}
		return false;
	}


	bool checkSwipe60(float xdir, float ydir, float slope)
	{
		if (Mathf.Abs (xdir) <= 20.0f && Mathf.Abs (ydir) <= 20.0f) { // Middle
			Debug.Log ("Middle");
			if(currRed == 8)
				return true;
		}
		
		
		if (ydir > 0) { // Upper part
			if( (slope < 0) && (slope > (-Mathf.Sqrt(3))) ) // Upper Left
			{
				if(currRed == 3)
					return true;
				
				Debug.Log ("Upper Left");
			}
			else if( (slope > 0) && (slope < (Mathf.Sqrt(3))) ) // Upper Right
			{
				if(currRed == 7)
					return true;
				
				Debug.Log ("Upper Right");
			}
			else
			{
				if(currRed == 2)
					return true;
				
				Debug.Log ("Up");
			}
		} else { // Lower part
			if( (slope < 0) && (slope > (-Mathf.Sqrt(3))) ) 
			{
				if(currRed == 6)
					return true;
				
				Debug.Log ("Lower Right");
			}
			else if( (slope > 0) && (slope < (Mathf.Sqrt(3))) ) // Upper Right
			{
				if(currRed == 4)
					return true;
				
				Debug.Log ("Lower Left");
			}
			else
			{
				if(currRed == 5)
					return true;
				
				Debug.Log ("Down");
			}
		}
		return false;
	}


	bool checkSwipe36(float xdir, float ydir, float slope)
	{
		Debug.Log ("36 degree");
		float height35 = Mathf.Tan (Mathf.Deg2Rad * 35 );
		float height70 = Mathf.Tan (Mathf.Deg2Rad * 70 );

		if (Mathf.Abs (xdir) <= 20.0f && Mathf.Abs (ydir) <= 20.0f) { // Middle
			Debug.Log ("Middle");
			if(currRed == 12)
				return true;
		}
		
		
		if (ydir > 0) { // Upper part
			if( (slope < 0) && (slope > -1.0f * height35) ) // Upper Left
			{
				if(currRed == 5)
					return true;
				
				Debug.Log ("Upper Left");
			}
			else if( (slope < -1.0f * height35) && (slope > -1.0 * height70)) // Upper upper Left
			{
				if(currRed == 4)
					return true;
				
				Debug.Log ("Upper upper Left");
			}
			else if( (slope > 0) && (slope < height35) ) // Upper Right
			{
				if(currRed == 11)
					return true;
				
				Debug.Log ("Upper Right");
			}
			else if( (slope > height35) && (slope < height70) ) // Upper upper Right
			{
				if(currRed == 2)
					return true;
				
				Debug.Log ("Upper upper Right");
			}
			else
			{
				if(currRed == 3)
					return true;
				
				Debug.Log ("Up");
			}
			
			
		} else { // Lower part
			if( (slope < 0) && (slope > -1.0f * height35) ) // Lower Right
			{
				if(currRed == 10)
					return true;
				
				Debug.Log ("Lower Right");
			}
			else if( (slope < -1.0f * height35) && (slope > -1.0 * height70)) // Lower Lower Right
			{
				if(currRed == 9)
					return true;
				
				Debug.Log ("Lower Lower Right");
			}
			else if( (slope > 0) && (slope < height35) ) // Lower Left
			{
				if(currRed == 6)
					return true;
				
				Debug.Log ("Lower Left");
			}
			else if( (slope > height35) && (slope < height70) ) // Lower Lower Left
			{
				if(currRed == 7)
					return true;
				
				Debug.Log ("Lower Lower Left");
			}
			else
			{
				if(currRed == 8)
					return true;
				
			}
		}
		return false;
	}



}
