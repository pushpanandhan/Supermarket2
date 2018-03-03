using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadSelect : MonoBehaviour {

	public static int BreadCount = 0;

	void OnMouseDown(){
		BreadCount++;
		Debug.Log ("Bread "+BreadCount);
	}
}
