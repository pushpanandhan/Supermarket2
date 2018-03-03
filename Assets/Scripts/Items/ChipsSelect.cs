using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipsSelect : MonoBehaviour {
	public static int ChipsCount = 0;

	void OnMouseDown(){
		ChipsCount++;
		Debug.Log ("Chips "+ChipsCount);
	}
}
