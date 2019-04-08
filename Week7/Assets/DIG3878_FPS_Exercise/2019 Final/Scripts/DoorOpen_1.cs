using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen_1 : MonoBehaviour
{
    /*//set to trigger volume
    //tag FPS Controller as "Player"

    public GameObject speechBubble; //display in Canvas when in the trigger volume
    public GameObject lockedBubble;
    //public Material matButton; // for speechBubble to tell player what to press
    //public Material matTalking; // for speechBubble to show NPC is talking after pressing button and text is displayed
    //public AudioClip hey; //sound for near door
    public AudioClip doorSound; // sound for door
    public AudioClip lockedSound;
    public GameObject door; //the door object
    //public GameObject npcDialogue; // the dialogue as Canvas text (can be an empty with UI background image and text or just the text)
    bool open = false; // says if door has been opened
    bool nearDoor = false; // says if near door

    void Start()
    {
        speechBubble.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && open == false && PlayerScoreFixRobot.doorUnlocked == true) // only works after getting close, hasn't been opened, and robots fixed
        {
            speechBubble.SetActive(true); // displays what button player should press as Canvas UI
            Debug.Log("Near Door"); // for testing
            nearDoor = true; // says door display on
        }
        else if (collision.CompareTag("Player") && open == false && PlayerScoreFixRobot.doorUnlocked == false)
        {
            speechBubble.SetActive(true); // displays what button player should press as Canvas UI
            Debug.Log("Near Door"); // for testing
            nearDoor = true; // says door display on
        }
        else if (collision.CompareTag("Player") && open == true && PlayerScoreFixRobot.doorUnlocked == true)
        {
            speechBubble.SetActive(true); // displays what button player should press as Canvas UI
            Debug.Log("Near Door"); // for testing
            nearDoor = true; // says door display on
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player") // if you are leaving robot trigger volume -- non-decoy bot
        {
            nearDoor = false; // not in volume
            speechBubble.SetActive(false);
            Debug.Log("left door end volume");
            if (open == false && PlayerScoreFixRobot.doorUnlocked == false)
            {
                lockedBubble.SetActive(false);
            }
        }

        /*if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(false); // goes away
            lockedBubble.SetActive(false);
            if (open == false)
            {
                speechBubble.SetActive(false); // goes away
                lockedBubble.SetActive(false);
            }
            if (displayed == true)
            { // if it is displayed
                npcDialogue.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
                speechBubble.GetComponent<Renderer>().material = matButton; // go back to first texture on Speech Bubble
            }
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && nearDoor == true && open == false && PlayerScoreFixRobot.doorUnlocked == true) // if press button and near door
        { //if the player presses the mouse button (or replace with desired key or button)
            //speechBubble.GetComponent<Renderer>().material = matTalking;
            AudioSource.PlayClipAtPoint(doorSound, transform.position); // play NPC dialogue
            open = true; // says door is open
            speechBubble.SetActive(false); // destroys this so won't display again
            //door.GetComponent<Animator>().SetBool("Open", true); // tells door to do animation
            Destroy(door); // destroys the door for now--add animation after
            Debug.Log("Open"); // for testing
            nearDoor = false; // keeps you from pressing and hearing sound multiple times
        }
        else if (Input.GetButtonDown("Fire1") && nearDoor == true && open == false && PlayerScoreFixRobot.doorUnlocked == false) // if press button and near door
        { //if the player presses the mouse button (or replace with desired key or button)
            //speechBubble.GetComponent<Renderer>().material = matTalking;
            AudioSource.PlayClipAtPoint(lockedSound, transform.position); // play NPC dialogue
            open = false; // says door is open
            speechBubble.SetActive(false);
            lockedBubble.SetActive(true);
            //door.GetComponent<Animator>().SetBool("Open", true); // tells door to do animation
            Debug.Log("Locked"); // for testing
            nearDoor = false; // keeps you from pressing and hearing sound multiple times
        }
    }*/
}
