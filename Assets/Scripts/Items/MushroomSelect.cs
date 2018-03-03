using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSelect : MonoBehaviour {

	public static int MushroomCount = 0;

	void OnMouseDown(){
		MushroomCount++;
		Debug.Log ("Mushroom "+MushroomCount);


	}
}
