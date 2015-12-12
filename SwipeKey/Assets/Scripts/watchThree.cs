using UnityEngine;
using System.Collections;

public class watchThree : MonoBehaviour {
	
	public swipeNine prebutton;
	public swipeNine[] buttonList;
	private const float buttonW = 1.8f;
	private const float buttonH = 1.8f;
	private const float originX = -1.8f;
	private const float originY = -1.0f;
	
	
	// Use this for initialization
	void Start () {
		for (int i=0; i<3; i++) 
		{
			createButton(i);		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void createButton(int i)
	{
		float buttonX = originX + i*buttonW;
		swipeNine newButton =(swipeNine)Instantiate(buttonList[i]);
		newButton.transform.position = new Vector3(buttonX,originY,0);
		newButton.buttonNumber = i + 1;
		newButton.name = "button-" + (i+1).ToString();
	}
}
