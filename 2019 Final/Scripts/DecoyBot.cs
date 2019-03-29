using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyBot : MonoBehaviour
{
    // attach this to Fixbot trigger volume
    // Player tagged "Player"

    public GameObject decoybot; // the non-decoy bots
    public GameObject speechBubble; // tells player what to push--will need one for every bot
    public GameObject talkedText; // a GameObject or text that says you talked to the bot
    bool displayed = false; // says if fixedText is displayed

    bool decoybotTrigger = false; // says you are in robot trigger volume -- non-decoy
    bool talkedToTheBot = false; // says whether you've fixed the robot (so can't multiple times)

    public AudioClip robotbeep; // robot audio
    public AudioClip happybeep; // robot audio
    //public Material matFixed; // mat for fixed robot (display the number?)


    //public Text scoreText; // score text in UI in PlayerScoreFixRobot.cs
    //public Text botText; // text in UI shows how many bots you've fixed

    //public static int playerscore; // score
    //public static int robotCount = 0; // score number -- kept static for convenience across multiple scripts
    //public static int botsToFix; // set how many bots you want to fix per level -- kept as static for now

    void Start()
    {
        //keeps these off at first
        speechBubble.SetActive(false);
        talkedText.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") // if you are in robot trigger volume -- non-decoy bot
        {
            decoybotTrigger = true;
            Debug.Log("near bot");
            if (talkedToTheBot == false)
            {
                speechBubble.SetActive(true); // displays what button player should press as Canvas UI
                AudioSource.PlayClipAtPoint(robotbeep, transform.position);
            }
            else if (talkedToTheBot == true)
            {
                talkedText.SetActive(true); // if already talked to him, display the text again when in volume
            }
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") // if you are leaving robot trigger volume -- non-decoy bot
        {
            decoybotTrigger = false; // not in volume
            talkedText.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
            Debug.Log("left robot volume");
            if (talkedToTheBot == false)
            {
                speechBubble.SetActive(false); // displays what button player should press as Canvas UI
            }
        }
    }

    public void Update()
    {
        if (decoybotTrigger == true && talkedToTheBot == false && Input.GetKeyDown(KeyCode.F))
        {
            //does not add to robot count
            PlayerScoreFixRobot.playerscore += 2; // adds to player score
            AudioSource.PlayClipAtPoint(happybeep, transform.position);
            // matFixed?
            talkedToTheBot = true; // says bot is fixed
            speechBubble.SetActive(false); // destroys speechbubble
            talkedText.SetActive(true); // says you fixed the bot
            // decoybot.GetComponent<Animator>().SetBool("Fixed", true); // for animation
            Debug.Log("Talked To Decoy");
        }
    }
}
