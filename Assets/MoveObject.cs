using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	public float jumpHeight = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveValue = transform.position;
		if( Input.GetButtonUp("Jump") ) {
			moveValue.y += jumpHeight;
		}
		moveValue.z += Input.GetAxis ("Vertical") / 2;
		transform.position = moveValue;

		transform.Rotate(0, Input.GetAxis ("Horizontal") * 3, 0);

		if (Input.GetMouseButtonUp(0))
			transform.Translate (0f, 0f, 0.3f);
		if (Input.GetMouseButtonUp(1))
			transform.Translate (0f, 0f, -0.3f);
	}
}
