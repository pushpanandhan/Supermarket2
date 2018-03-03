using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBowlSelect : MonoBehaviour {

	public static int MenuBowlCount = 0;

	void OnMouseDown(){
		MenuBowlCount++;
		Debug.Log ("MenuBowl "+MenuBowlCount);

	}
}
