using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilSelect : MonoBehaviour {

	public static int SoilCount = 0;

	void OnMouseDown(){
		SoilCount++;
		Debug.Log ("Soil "+SoilCount);

	}
}
