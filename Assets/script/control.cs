using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
	public int xDivider = 62;
	public int yDivider = 72;

	private Vector3 mousePos;

	void OnMouseDrag ()
	{
		float mouseX = Input.mousePosition.x / xDivider;
		float mouseY = Input.mousePosition.y /yDivider;
		mousePos = new Vector3(mouseX, mouseY, 0);
		transform.position = mousePos;

	}

	void OnMouseUp ()
	{
		int mouseX = Mathf.RoundToInt(Input.mousePosition.x / xDivider);
		int mouseY = Mathf.RoundToInt(Input.mousePosition.y /yDivider);
		mousePos = new Vector3(mouseX, mouseY, 0);
		transform.position = mousePos;

	}

}
