using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvocadoSelect : MonoBehaviour {

	public static int avacadoCount = 0;

	void OnMouseDown(){
		avacadoCount++;
		Debug.Log ("avacado "+avacadoCount);
	
	}
}
