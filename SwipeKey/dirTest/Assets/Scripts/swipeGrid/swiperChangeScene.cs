using UnityEngine;
using System.Collections;

public class swiperChangeScene : MonoBehaviour {
	public int scene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeToScene(){
		Application.LoadLevel (scene);
	}

}
