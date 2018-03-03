using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSelect : MonoBehaviour {

	public static int CheeseCount = 0;

	void OnMouseDown(){
		CheeseCount++;
		Debug.Log ("Cheese "+CheeseCount);

	}
}
