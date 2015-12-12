using UnityEngine;
using System.Collections;

public class swipeWatch : MonoBehaviour {


	public swipeButton prebutton;
	public swipeButton[] buttonList;
	private const float buttonW = 1.35f;
	private const float buttonH = 1.35f;
	private const float originX = -2f;
	private const float originY = -0.4f;
	

	// Use this for initialization
	void Start () {
//		for (int i=0; i<8; i++) 
//		{
//			createButton(i);		
//		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void createButton(int i)
//	{
//		float buttonX = originX + (i%4)*buttonW;
//		float buttonY = originY - (i/4)*buttonH;
//		swipeButton newButton =(swipeButton)Instantiate(buttonList[i]);
//		newButton.transform.position = new Vector3(buttonX,buttonY,0);
//		newButton.buttonNumber = i + 1;
//		newButton.name = "button-" + (i+1).ToString();
//	}
}
