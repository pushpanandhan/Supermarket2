using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatSelect : MonoBehaviour {

	public static int MeatCount = 0;

	void OnMouseDown(){
		MeatCount++;
		Debug.Log ("Meat "+MeatCount);

	}
}
