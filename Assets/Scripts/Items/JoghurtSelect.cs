using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoghurtSelect : MonoBehaviour {

	public static int  JoghurtCount = 0;

	void OnMouseDown(){
		JoghurtCount++;
		Debug.Log (" Joghurt "+ JoghurtCount);
	}
}
