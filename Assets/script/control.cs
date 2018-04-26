using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
	public float sizeX = 1;
	public float sizeY = 1;

	//initiate mouse & object position vector3
	private Vector3 mousePos;
	private Vector3 objPos;
	private float x,  y;

	void OnMouseDrag(){
		//get mouse position and translate it into world position
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
		objPos = Camera.main.ScreenToWorldPoint (mousePos);
		objPos = new Vector3 (objPos.x, objPos.y, transform.position.z);
		transform.position = objPos;
	
	}
	void OnMouseUp(){
		float xGrid = 1/(sizeX / 2);
		float yGrid = 1/(sizeY / 2);

		x = Mathf.Round (transform.position.x * xGrid) / xGrid;
		y = Mathf.Round (transform.position.y * yGrid) / yGrid;
		Debug.Log ("x location:" + x + ", y location:" + y);
		transform.position = new Vector3 (x, y, transform.position.z);
	}


}
