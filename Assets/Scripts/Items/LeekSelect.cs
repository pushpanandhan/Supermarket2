using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeekSelect : MonoBehaviour {

	public static int LeekCount = 0;

	void OnMouseDown(){
		LeekCount++;
		Debug.Log ("Leek "+LeekCount);

	}
}
