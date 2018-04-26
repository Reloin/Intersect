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
	private int intBlue = 0;
	private int intYellow = 0;

	void Start () 
	{
		//get renderer
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}

	void OnTriggerEnter(Collider col)
	{

		//check what color intersect with our shapes
		if (intBlue > 0 && intYellow > 0){
			rend.sharedMaterial = black; 
		}
		//red + blue = purple
		if (col.transform.CompareTag("Blue")){
			rend.sharedMaterial = purple; 
			++intBlue;
			Debug.Log ("Red sqr Blue count:" + intBlue);
		}
		//red + yellow = orange
		else if (col.transform.CompareTag("Yellow")){
			rend.sharedMaterial = orange; 
			++intYellow;
			Debug.Log ("Red sqr Yellow count:" + intYellow);
		}

	}
		

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Blue")){
			--intBlue;
			Debug.Log ("Red sqr Blue count:" + intBlue);
		}
		//red + yellow = orange
		else if (col.transform.CompareTag("Yellow")){
			--intYellow;
			Debug.Log ("Red sqr Yellow count:" + intYellow);
		}
		if (intBlue == 0 && intYellow == 0) {
			rend.sharedMaterial = red;
		}

	}
}
