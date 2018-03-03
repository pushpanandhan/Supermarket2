using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour {
    public static int bananaCount = 0;

    void OnMouseDown()
    {
        bananaCount++;
        Debug.Log("Banana " + bananaCount );
    }
}
