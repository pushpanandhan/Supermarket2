using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text bananacount;
    public Text carrottext;
    public Text tomatotext;
    public Text mushroomtext;
    // Update is called once per frame
    void Update () {
        bananacount.text = "Banana : " + BananaScript.bananaCount+"     ";
        carrottext.text = "Carrot : " + CarrotSelect.CarrotCount+"      ";
        tomatotext.text = "Tomato : " + TomatoSelect.TomatoCount+"      ";
        mushroomtext.text = "Mushroom : " + MushroomSelect.MushroomCount+"      ";
    }
}
