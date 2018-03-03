using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSelect : MonoBehaviour {

	public static int CarrotCount = 0;

	void OnMouseDown(){
		CarrotCount++;
		Debug.Log ("Carrot "+CarrotCount);

	}
}
