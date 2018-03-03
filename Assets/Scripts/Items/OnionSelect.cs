using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionSelect : MonoBehaviour {

	public static int OnionCount = 0;

	void OnMouseDown(){
		OnionCount++;
		Debug.Log ("Onion "+OnionCount);

	}
}
