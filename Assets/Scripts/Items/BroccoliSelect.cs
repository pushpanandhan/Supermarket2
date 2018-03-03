using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroccoliSelect : MonoBehaviour {

	public static int BroccoliCount = 0;

	void OnMouseDown(){
		BroccoliCount++;
		Debug.Log ("Broccoli "+BroccoliCount);

	}
}
