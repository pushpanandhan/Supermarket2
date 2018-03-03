using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoSelect : MonoBehaviour {

	public static int TomatoCount = 0;

	void OnMouseDown(){
		TomatoCount++;
		Debug.Log ("Tomato "+TomatoCount);
	}
}
