using UnityEngine;
using System.Collections;

public class changeDirectionNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void restart10(){
		swipeWatch.triangleDegree = 36;
		swipeWatch.includeMiddle = false;
		Application.LoadLevel(0);
	}

	public void restart10middle()
	{
		swipeWatch.triangleDegree = 36;
		swipeWatch.includeMiddle = true;
		Application.LoadLevel(0);
	}
	
	public void restart6(){
		swipeWatch.triangleDegree = 60;
		swipeWatch.includeMiddle = false;
		Application.LoadLevel(0);
	}

	public void restart6middle()
	{
		swipeWatch.triangleDegree = 60;
		swipeWatch.includeMiddle = true;
		Application.LoadLevel(0);
	}
	
	public void restart4()
	{
		swipeWatch.triangleDegree = 90;
		swipeWatch.includeMiddle = false;
		Application.LoadLevel(0);
	}

	public void restart4middle()
	{
		swipeWatch.triangleDegree = 90;
		swipeWatch.includeMiddle = true;
		Application.LoadLevel(0);
	}
}
