using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearSelect : MonoBehaviour {

	public static int PearCount = 0;

	void OnMouseDown(){
		PearCount++;
		Debug.Log ("Pear "+PearCount);


	}
}
