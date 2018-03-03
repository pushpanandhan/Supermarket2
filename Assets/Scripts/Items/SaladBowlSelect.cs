using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaladBowlSelect : MonoBehaviour {
	public static int SaladBowlCount = 0;

	void OnMouseDown(){
		SaladBowlCount++;
		Debug.Log ("SaladBowl "+SaladBowlCount);
	}
}
