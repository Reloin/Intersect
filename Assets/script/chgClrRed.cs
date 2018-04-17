using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chgClrRed : MonoBehaviour {
	//used to store 4 possible colors of red
	public Material red;
	public Material purple;
	public Material orange;
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

		Debug.Log ("Red count:"+ triggerCount);
		//check what color intersect with our shapes
		if (triggerCount >= 2){
			rend.sharedMaterial = black; 
		}
		//red + blue = purple
		if (col.transform.CompareTag("Blue")){
			rend.sharedMaterial = purple; 
			++triggerCount;
		}
		//red + yellow = orange
		else if (col.transform.CompareTag("Yellow")){
			rend.sharedMaterial = orange; 
			++triggerCount;
		}

	}
		

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Blue")){
			--triggerCount;
		}
		//red + yellow = orange
		else if (col.transform.CompareTag("Yellow")){
			--triggerCount;
		}
		if (triggerCount == 0) {
			rend.sharedMaterial = red;
		}
		Debug.Log ("Red count:"+ triggerCount);
	}
}
