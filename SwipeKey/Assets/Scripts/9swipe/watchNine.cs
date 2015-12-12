using UnityEngine;
using System.Collections;

public class watchNine : MonoBehaviour {

	public swipeNine prebutton;
	public swipeNine[] buttonList;
	public swipeThree prebuttonThree;
	public swipeThree[] buttonListThree;
	private const float buttonW = 1.8f;
	private const float buttonH = 1.8f;
	private const float buttonThreeW = 1.3f;
	private const float buttonThreeH = 1.3f;
	private const float originX = -1.8f;
	private const float originY = -0.9f;
	private const float originThreeX = -2.0f;
	private const float originThreeY = -2.3f;

	
	// Use this for initialization
	void Start () {
//		for (int i=0; i<3; i++) 
//		{
//			createButton(i);		
//		}
//		for (int i=0; i<3; i++) 
//		{
//			createButtonThree(i);		
//		}
	}
	void createButton(int i)
	{
		float buttonX = originX + i*buttonW;
		swipeNine newButton =(swipeNine)Instantiate(buttonList[i]);
		newButton.transform.position = new Vector3(buttonX,originY,0);
		newButton.buttonNumber = i + 1;
		newButton.name = "9button-" + (i+1).ToString();
	}
	// Update is called once per frame
	void Update () {
		
	}
	

	void createButtonThree(int i)
	{
		float buttonX = originThreeX + i*buttonThreeW;
		swipeThree newButton =(swipeThree)Instantiate(buttonListThree[i]);
		newButton.transform.position = new Vector3(buttonX,originThreeY,0);
		newButton.buttonNumber = i + 1;
		newButton.name = "3button-" + (i+1).ToString();
	}
}
