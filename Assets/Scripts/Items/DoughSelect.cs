using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughSelect : MonoBehaviour {

	public static int DoughCount = 0;

	void OnMouseDown(){
		DoughCount++;
		Debug.Log ("Dough "+DoughCount);

}
}