using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSelect : MonoBehaviour {
	public static int appleCount = 0;

	void OnMouseDown(){
		appleCount++;
		Debug.Log ("Apple "+appleCount);
	}
}
