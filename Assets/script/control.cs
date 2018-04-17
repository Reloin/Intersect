using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
	public float sizeX = 1;
	public float sizeY = 1;

	//initiate mouse & object position vector3
	private Vector3 mousePos;
	private Vector3 objPos;
	private float x = 0f,  y = 0f;

	void OnMouseDrag(){
		//get mouse position and translate it into world position
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
		objPos = Camera.main.ScreenToWorldPoint (mousePos);
		objPos = new Vector3 (objPos.x, objPos.y, transform.position.z);
		transform.position = objPos;
	
	}
	void OnMouseUp(){

		//snap to grid what release mouse button
		float reciprocalGridX = 1f / sizeX;
		float reciprocalGridY = 1f / sizeY;

		x = Mathf.Round (transform.position.x * reciprocalGridX) / reciprocalGridX;
		y = Mathf.Round (transform.position.y * reciprocalGridY) / reciprocalGridY;

		transform.position = new Vector3 (x, y, transform.position.z);
	}


}
