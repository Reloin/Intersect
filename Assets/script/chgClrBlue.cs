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
	private int intRed = 0;
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
		if (intRed > 0 && intYellow > 0){
			rend.sharedMaterial = black; 
		}
		//blue + red = purple
		if (col.transform.CompareTag("Red")){
			rend.sharedMaterial = purple;
			++intRed;
			Debug.Log ("Blue sqr Red count:" + intRed);
		}
		//blur + yellow = green
		else if (col.transform.CompareTag("Yellow")){
			rend.sharedMaterial = green;
			++intYellow;
			Debug.Log ("Blue sqr yellow count:" + intYellow);
		}

	}

	void OnTriggerExit(Collider col)
	{
		if (col.transform.CompareTag("Red")){
			--intRed;
			Debug.Log ("Blue sqr Red count:" + intRed);
		}
		else if (col.transform.CompareTag("Yellow")){
			--intYellow;
		}
		if (intRed == 0 && intYellow == 0) {
			rend.sharedMaterial = blue;
			Debug.Log ("Blue sqr yellow count:" + intYellow);
		}
	}
}
