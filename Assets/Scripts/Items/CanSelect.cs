using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSelect : MonoBehaviour {

	public static int CanCount = 0;

	void OnMouseDown(){
		CanCount++;
		Debug.Log ("Can "+CanCount);
	}
}
