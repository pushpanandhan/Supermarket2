using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperoniSelect : MonoBehaviour {

	public static int PepperoniCount = 0;

	void OnMouseDown(){
		PepperoniCount++;
		Debug.Log ("Pepperoni "+PepperoniCount);

	}
}
