using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonSelect : MonoBehaviour {
    public static int lemonCount = 0;

    void OnMouseDown()
    {
        lemonCount++;
        Debug.Log("Lemon " + lemonCount);
    }

}
