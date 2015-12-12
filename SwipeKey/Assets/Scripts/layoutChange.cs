using UnityEngine;
using System.Collections;

public class layoutChange : MonoBehaviour {
	public Animator layout;
	// Use this for initialization
	void Start () {
		RectTransform transform = layout.gameObject.transform as RectTransform;
		Vector2 position = transform.anchoredPosition;
		position.y -= transform.rect.height;
		transform.anchoredPosition = position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggleLayout(){
		layout.enabled = true;
		bool IsHidden = layout.GetBool ("IsHidden");
		layout.SetBool("IsHidden",!IsHidden);
	}

}
