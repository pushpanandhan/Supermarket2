using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_scaledSelect : MonoBehaviour {
	public static int  Can_scaledCount = 0;

	void OnMouseDown(){
		Can_scaledCount++;
		Debug.Log (" Can_scaled "+ Can_scaledCount);
	}
}
