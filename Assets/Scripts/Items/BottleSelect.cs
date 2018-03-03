using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSelect : MonoBehaviour {

	public static int BottleCount = 0;

	void OnMouseDown(){
		BottleCount++;
		Debug.Log ("Bottle "+BottleCount);
	}
}
