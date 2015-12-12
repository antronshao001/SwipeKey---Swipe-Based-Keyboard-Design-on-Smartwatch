using UnityEngine;
using System.Collections;

public class watchFive : MonoBehaviour {
	
	
	public swipeFive prebutton;
	public swipeFive[] buttonList;
	private const float buttonW = 1.75f;
	private const float buttonH = 1.6f;
	private const float originX = -1.75f;
	private const float originY = -0.3f;
	
	
	// Use this for initialization
	void Start () {
//		for (int i=0; i<6; i++) 
//		{
//			createButton(i);		
//		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
//	void createButton(int i)
//	{
//		float buttonX = originX + (i%3)*buttonW;
//		float buttonY = originY - (i/3)*buttonH;
//		swipeFive newButton =(swipeFive)Instantiate(buttonList[i]);
//		newButton.transform.position = new Vector3(buttonX,buttonY,0);
//		newButton.buttonNumber = i + 1;
//		newButton.name = "button-" + (i+1).ToString();
//	}
}
