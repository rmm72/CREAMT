using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreFruit : MonoBehaviour {
    //create GameManager and attach this script

    public static int ascore = 0;
    public static int oscore = 0;
    public static int lscore = 0;
    //public static int gscore = 0;

    public Text orangeText;
    public Text appleText;
    public Text lemonText;
    //public Text scoreText;

    void Update()
    {
        orangeText.text = "Oranges Collected " + oscore + "/5";
        appleText.text = "Apples Collected " + ascore + "/5";
        lemonText.text = "Lemons Collected " + lscore + "/5";
        //scoreText.text = "Score: " + gscore;
        if (ascore >= 5 && oscore >= 5 && lscore >= 5)
        {
            SceneManager.LoadScene("FB_End_Screen");
        }
    }
}
