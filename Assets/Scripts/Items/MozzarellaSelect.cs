using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MozzarellaSelect : MonoBehaviour {

	public static int MozzarellaCount = 0;

	void OnMouseDown(){
		MozzarellaCount++;
		Debug.Log ("Mozzarella "+MozzarellaCount);

	}
}
