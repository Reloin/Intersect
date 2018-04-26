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
	private int intRed = 0;
	private int intBlue = 0;

	void Start () 
	{
		//get renderer
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}

	void OnTriggerEnter(Collider col)
	{


		//check what color intersect with our shapes
		if (intRed > 0 && intBlue > 0){
			rend.sharedMaterial = black; 
		}
		//yellow + red = orange
		if (col.transform.CompareTag("Red")){
			rend.sharedMaterial = orange; 
			++intRed;
			Debug.Log ("Yellow sqr Red count:" + intRed);
		}
		//yellow + blue = green
		else if (col.transform.CompareTag("Blue")){
			rend.sharedMaterial = green; 
			++intBlue;
			Debug.Log ("Yellow sqr Blue count:" + intBlue);
		}

	}
		

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Red")){
			--intRed;
			Debug.Log ("Yellow sqr Red count:" + intRed);
		}
		//yellow + blue = green
		else if (col.transform.CompareTag("Blue")){
			--intBlue;
			Debug.Log ("Yellow sqr Blue count:" + intBlue);
		}
		if (intRed == 0 && intBlue == 0) {
			rend.sharedMaterial = yellow;
		}

	}
}
