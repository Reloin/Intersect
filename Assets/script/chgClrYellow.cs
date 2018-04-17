using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chgClrYellow : MonoBehaviour {
	//used to store 4 possible colors for yellow
	public Material yellow;
	public Material orange;
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

		Debug.Log ("yellow count:"+ triggerCount);
		//check what color intersect with our shapes
		if (triggerCount >= 2){
			rend.sharedMaterial = black; 
		}
		//yellow + red = orange
		if (col.transform.CompareTag("Red")){
			rend.sharedMaterial = orange; 
			++triggerCount;
		}
		//yellow + blue = green
		else if (col.transform.CompareTag("Blue")){
			rend.sharedMaterial = green; 
			++triggerCount;
		}

	}
		

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Red")){
			--triggerCount;
		}
		//yellow + blue = green
		else if (col.transform.CompareTag("Blue")){
			--triggerCount;
		}
		if (triggerCount == 0) {
			rend.sharedMaterial = yellow;
		}
		Debug.Log ("yellow count:"+ triggerCount);
	}
}
