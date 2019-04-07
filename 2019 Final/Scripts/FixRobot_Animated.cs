using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixRobot_Animated : MonoBehaviour
{
    // attach this to Fixbot trigger volume
    // Player tagged "Player"

    public GameObject fixbot; // the non-decoy bots
    public GameObject speechBubble; // tells player what to push--will need one for every bot
    public GameObject robotName;
    public GameObject fixedText; // a GameObject or text that says you fixed the bot
    public GameObject fixText; // prompts player to fix the robot
    public GameObject findItem; // tells player its broken
    //bool displayed = false; // says if fixedText is displayed
    public GameObject sparks;

    bool fixbotTrigger = false; // says you are in robot trigger volume -- non-decoy
    bool fixedTheBot = false; // says whether you've fixed the robot (so can't multiple times)

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
        fixedText.SetActive(false);
        robotName.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") // if you are in robot trigger volume -- non-decoy bot
        {
            fixbotTrigger = true;
            Debug.Log("near bot");
            if (fixedTheBot == false && ItemInventory.gscore == 0)
            {
                speechBubble.SetActive(true); // displays what button player should press as Canvas UI
                AudioSource.PlayClipAtPoint(robotbeep, transform.position);
            }
            else if (fixedTheBot == false && ItemInventory.gscore >= 1){
                fixText.SetActive(true); // if already fixed, display the text again when in volume
            }
            else if (fixedTheBot == true)
            {
                fixedText.SetActive(true); // if already fixed, display the text again when in volume
                robotName.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") // if you are leaving robot trigger volume -- non-decoy bot
        {
            fixbotTrigger = false; // not in volume
            fixedText.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
            robotName.SetActive(false);
            fixText.SetActive(false);
            Debug.Log("left robot volume");
            if (fixedTheBot == false)
            {
                speechBubble.SetActive(false); // displays what button player should press as Canvas UI
                findItem.SetActive(false);
                robotName.SetActive(false);
            }
        }
    }

    public void Update()
    {
        if (fixbotTrigger == true && fixedTheBot == false && Input.GetButtonDown("Fire1") && ItemInventory.gscore == 0) 
        {
            findItem.SetActive(true);
            speechBubble.SetActive(false);
            robotName.SetActive(true);
            AudioSource.PlayClipAtPoint(robotbeep, transform.position);
            Debug.Log("Talking"); // for testing
        }
        else if (fixbotTrigger == true && fixedTheBot == false && Input.GetKeyDown(KeyCode.F) && ItemInventory.gscore >= 1)
        {
            PlayerScoreFixRobot.robotCount += 1; // adds one of robots fixed number
            //PlayerScoreFixRobot.playerscore += 5; // adds to player score
            Debug.Log("Score");
            AudioSource.PlayClipAtPoint(happybeep, transform.position);
            // matFixed?
            Debug.Log("audio");
            fixedTheBot = true; // says bot is fixed
            Debug.Log("says bot fixed");
            speechBubble.SetActive(false); // destroys speechbubble
            fixedText.SetActive(true); // says you fixed the bot
            fixText.SetActive(false);
            robotName.SetActive(true);
            Debug.Log("Text switch");
            ItemInventory.gscore--;
            Debug.Log("Item calculated");
            GetComponent<Animator>().SetBool("Fixed", true); // tells the animator controller that the bool is true and to switch animations
            Debug.Log("Fixed true");
            Debug.Log("Fixed");
            //Destroy(sparks); // will destroy the sparks
        }
    }
}