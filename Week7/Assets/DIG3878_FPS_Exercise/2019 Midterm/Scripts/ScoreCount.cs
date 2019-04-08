using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
    //create GameManager and attach this script

    public static int gscore = 0;

    public Text scoreText;
    public GameObject win;

    void Update()
    {
        scoreText.text = "Score: " + gscore;
        if (gscore == 5)
        {
            win.SetActive(true);
        }
    }

}
