using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkSelect : MonoBehaviour {

	public static int MilkCount = 0;

	void OnMouseDown(){
		MilkCount++;
		Debug.Log ("Milk "+MilkCount);
	}
}
