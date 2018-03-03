using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichSelect : MonoBehaviour {

	public static int SandwichCount = 0;

	void OnMouseDown(){
		SandwichCount++;
		Debug.Log ("Sandwich "+SandwichCount);
	}
}
