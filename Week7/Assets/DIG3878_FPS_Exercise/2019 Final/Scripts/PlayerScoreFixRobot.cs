using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreFixRobot : MonoBehaviour
{
    // attach this script to the player

    //public GameObject fixbot; // tag as "Fixbot" -- for the non-decoy bots
    //public GameObject decoybot; // tag as "Decoy"

    //bool fixbotTrigger = false; // says you are in robot trigger volume -- non-decoy
    //bool fixedTheBot = false; // says whether you've fixed the robot (so can't multiple times)

    //bool decoybotTrigger = false; // says you are in decoy bot trigger volume

    /*public AudioClip robotbeep; // robot audio
    public AudioClip happybeep; // robot audio
    public Material matFixed; // mat for fixed robot (display the number?)*/

    public Text scoreText; // score text in UI--leave empty
    public Text botText; // text in UI shows how many bots you've fixed--leave empty

    //public static int playerscore; // score
    public static int robotCount = 0; // score number -- kept static for convenience across multiple scripts
    public int botsToFix = 1; // set how many bots you want to fix per level -- kept as static for now

    public GameObject winLevelText; // text that says you won the level
    public static bool doorUnlocked = false;
    public static bool doorUnlockedB = false;
    public static bool doorUnlockedC = false;
    public static bool doorUnlockedD = false;
    public static bool doorText = false;
    //public string levelToLoad; // says which level you want to go to next

    void Update()
    {
        botText.text = robotCount + " / " + botsToFix + " Robots to Fix"; // how many bots you've fixed
        if (robotCount >= botsToFix && DoorOpen_KeypadA.nearDoor == false) // if have enough bots now door is unlocked
        {
            winLevelText.SetActive(true); // text tells player they can open the door if desired
            doorUnlocked = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadA.nearDoor == true) // if have enough bots now door is unlocked
        {
            Destroy(winLevelText); // text tells player they can open the door if desired
            doorUnlocked = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadB.nearDoorB == false) // if have enough bots now door is unlocked
        {
            winLevelText.SetActive(true); // text tells player they can open the door if desired
            doorUnlockedB = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadB.nearDoorB == true) // if have enough bots now door is unlocked
        {
            Destroy(winLevelText); // text tells player they can open the door if desired
            doorUnlockedB = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadC.nearDoorC == false) // if have enough bots now door is unlocked
        {
            winLevelText.SetActive(true); // text tells player they can open the door if desired
            doorUnlockedC = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadC.nearDoorC == true) // if have enough bots now door is unlocked
        {
            Destroy(winLevelText); // text tells player they can open the door if desired
            doorUnlockedC = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadD.nearDoorD == false) // if have enough bots now door is unlocked
        {
            winLevelText.SetActive(true); // text tells player they can open the door if desired
            doorUnlockedD = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount >= botsToFix && DoorOpen_KeypadD.nearDoorD == true) // if have enough bots now door is unlocked
        {
            Destroy(winLevelText); // text tells player they can open the door if desired
            doorUnlockedD = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }
        else if (robotCount < botsToFix)
        {
            winLevelText.SetActive(false); // text tells player they can open the door if desired
            doorUnlocked = false;
            doorUnlockedB = false;
            doorUnlockedC = false;
            doorUnlockedD = false;
        }

        //scoreText.text = "Score : " + playerscore; // display player score
    }
    /*IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(levelToLoad);
    }*/

    /*public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RobotTrigger") // if you are in robot trigger volume -- non-decoy bot
        {
            fixbotTrigger = true;
        } else if (col.gameObject.tag == "DecoyTrigger")
        {
            decoybotTrigger = true;
        }

    }

    public void OnCollisionExit(Collision collision)
    {
        fixbotTrigger = false;
        decoybotTrigger = false;
    }

    public void FixBot(){
        if (fixbotTrigger == true && fixedTheBot == false && Input.GetKeyDown(KeyCode.F)){
            robotCount += 1;
            AudioSource.PlayClipAtPoint(happybeep, transform.position);
            //matFixed?
            fixedTheBot = true;
            //fixbot.GetComponent<Animator>().SetBool("Fixed", true);
        }
    }*/
}
