using UnityEngine;
using System.Collections;

public class swipeWatch : MonoBehaviour {


	public swipeButton prebutton;
	public swipeButton[] buttonList;
	public triangle90[] triangeList;
	private const float buttonW = 1.75f;
	private const float buttonH = 1.05f;
	private const float originX = -1.75f;
	private const float originY = -0.1f;
	public Color highlight;

	public static int triangleDegree = 60;
	public static bool includeMiddle = true;

	// Use this for initialization
	void Start () {

		// Assign new mesh (of different triangles)
		Mesh triangleMesh = (Mesh)Resources.Load ("triangles/triangle "+ triangleDegree + " deg", typeof(Mesh));
		buttonList[1].GetComponent<MeshFilter> ().mesh = triangleMesh;


		createCollider ();

		int numOfTriangles = 360 / triangleDegree;
		int i;
		for (i=1; i < numOfTriangles + 1; i++) 
		{
			createButton(i);		
		}

		if (includeMiddle) {
			createMiddleButton(i);
		}





		// Pass angle value to swipeButton
		foreach (swipeButton button in buttonList) {
			button.triangleAngle = triangleDegree;
			Debug.Log("include middle" + includeMiddle);
			button.includeMiddle = includeMiddle;
		}




	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createButton(int i)
	{
		// float buttonX = originX + (i%3)*buttonW;
		// float buttonY = originY - (i/3)*buttonH;
		//swipeButton newButton =(swipeButton)Instantiate(buttonList[1]);
		swipeButton newButton =(swipeButton)Instantiate(buttonList[1]);
		newButton.transform.position = new Vector3(0.2f,0.9f,-1);
		if(triangleDegree == 90)
			newButton.transform.rotation = Quaternion.Euler ((i * triangleDegree)+45, -90, -90);
		else
			newButton.transform.rotation = Quaternion.Euler ((i * triangleDegree), -90, -90);
	
		newButton.buttonNumber = i + 1;
		newButton.name = "button-" + (i+1).ToString();
		newButton.renderer.material.color = highlight;
	}
	void createMiddleButton(int i)
	{
		swipeButton newButton =(swipeButton)Instantiate(buttonList[2]);
		newButton.transform.position = new Vector3(0.2f,0.9f,-1);
		newButton.renderer.material.color = highlight;
		//newButton.renderer.enabled = false;
		newButton.name = "button-" + (i+1).ToString();

	}

	void createCollider()
	{
		swipeButton newButton =(swipeButton)Instantiate(buttonList[0]);
		newButton.transform.position = new Vector3(0.2f,0.9f,-0.5f);
		newButton.transform.rotation = Quaternion.Euler (45, -90, -90);
		newButton.name = "button-" + '0'.ToString();

	}
	
}
