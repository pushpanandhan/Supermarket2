﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucumberSelect1 : MonoBehaviour {

	public static int CucumberCount = 0;

	void OnMouseDown(){
		CucumberCount++;
		Debug.Log ("Cucumber "+CucumberCount);

	}
}
