using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chgClrBlue : MonoBehaviour {
	//used to store 4 possible colors for blue
	public Material blue;
	public Material purple;
	public Material green;
	public Material black;

	private Renderer rend;
	private int triggerCount = 0;
	void Start () 
	{
		//get renderer
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}

	void OnTriggerEnter(Collider col)
	{
		

		//check what color intersect with our shapes
		if (triggerCount >= 2){
			rend.sharedMaterial = black; 
		}
		//blue + red = purple
		if (col.transform.CompareTag("Red")){
			rend.sharedMaterial = purple;
			++triggerCount;
		}
		//blur + yellow = green
		else if (col.transform.CompareTag("Yellow")){
			rend.sharedMaterial = green;
			++triggerCount;
		}
		Debug.Log ("blue count:"+ triggerCount);

	}

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Red")){
			--triggerCount;
		}
		else if (col.transform.CompareTag("Yellow")){
			--triggerCount;
		}
		if (triggerCount == 0) {
			rend.sharedMaterial = blue;
		}
		Debug.Log ("blue count:"+ triggerCount);
	}
}
