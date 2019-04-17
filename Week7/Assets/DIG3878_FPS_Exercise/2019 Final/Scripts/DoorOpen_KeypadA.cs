using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen_KeypadA : MonoBehaviour
{
    //set to trigger volume
    //tag FPS Controller as "Player"

    public GameObject speechBubble; //display in Canvas when door is locked and in trigger volume
    public GameObject lockedBubble;

    public AudioClip doorSound; // sound for door
    public AudioClip lockedSound;
    public Animator door; //the door object
    public GameObject doorCollider;
    //public GameObject npcDialogue; // the dialogue as Canvas text (can be an empty with UI background image and text or just the text)
    bool openDD = false; // says if door has been opened
    public static bool nearDDoor = false; // says if near door

    public GameObject interfaceSprite; //if you want to display an interface, probably like a screen so player doesn't think they can press UI buttons
    public static bool interfaceOff = true;
    public GameObject keypadInst;
    //public GameObject wrongInput; // says you put in wrong input
    //public GameObject key1Text; // will be the correct key (not automatically generated)
    //public GameObject key2Text; // will be the correct key (not automatically generated)
    //public GameObject key3Text; // will be the correct key (not automatically generated)
    string key;
    //bool rightkey1 = false;
    //bool rightkey2 = false;
    //bool rightkey3 = false;

    void Start()
    {
        speechBubble.SetActive(false);
        interfaceSprite.SetActive(false);
        doorCollider.SetActive(true);
        lockedBubble.SetActive(false);
        keypadInst.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && openDD == false && PlayerScoreFixRobot.doorUnlocked == true) // only works after getting close, hasn't been opened, and robots fixed
        {
            speechBubble.SetActive(true); // tells player to press the buttons 
            Debug.Log("Near Door1"); // for testing
            nearDDoor = true; // says door display on
            lockedBubble.SetActive(false);
        }
        else if (collision.CompareTag("Player") && openDD == false && PlayerScoreFixRobot.doorUnlocked == false) // locked
        {
            speechBubble.SetActive(true); // displays click to interact but will say door is locked
            Debug.Log("Near Door2"); // for testing
            nearDDoor = true; // says door display on
            lockedBubble.SetActive(false);
        }
        //else if (collision.CompareTag("Player") && open == true && PlayerScoreFixRobot.doorUnlocked == true)
        //{
        //    speechBubble.SetActive(true); // displays what button player should press as Canvas UI
        //    Debug.Log("Near Door3"); // for testing
        //    nearDoor = true; // says door display on
        //}
    }

    /*public void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && open == false && PlayerScoreFixRobot.doorUnlocked == true)
        {
            Cursor.visible = true;
        }
        else if (other.CompareTag("Player") && open == false && PlayerScoreFixRobot.doorUnlocked == false) // locked
        {
            Cursor.visible = false;
        }
    }*/

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player") // if you are leaving robot trigger volume -- non-decoy bot
        {
            nearDDoor = false; // not in volume
            speechBubble.SetActive(false);
            PlayerScoreFixRobot.doorText = false;
            Debug.Log("left door end volume");
            if (openDD == false && PlayerScoreFixRobot.doorUnlocked == false)
            {
                lockedBubble.SetActive(false);
            }
            interfaceOff = true;
            interfaceSprite.SetActive(false);
            keypadInst.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            //key1Text.SetActive(false);
            //key2Text.SetActive(false);
            //key3Text.SetActive(false);
            //rightkey1 = false;
            //rightkey2 = false;
            //rightkey3 = false;
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
        }*/
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && nearDDoor == true && openDD == false && PlayerScoreFixRobot.doorUnlocked == true && interfaceOff == true)
        { //if unlocked now have to press right keys
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            interfaceSprite.SetActive(true); // this pops up and tells the player to press the buttons
            keypadInst.SetActive(true);
            interfaceOff = false; // keeps you from pressing multiple times
            speechBubble.SetActive(false);
            lockedBubble.SetActive(false);
            Debug.Log("Interface on");
            }
        else if (Input.GetButtonDown("Fire1") && nearDDoor == true && openDD == false && PlayerScoreFixRobot.doorUnlocked == false)
        { //if the player presses the mouse button but door is locked
            AudioSource.PlayClipAtPoint(lockedSound, transform.position); // play NPC dialogue
            openDD = false; // says door is locked
            speechBubble.SetActive(false);
            lockedBubble.SetActive(true);
            Debug.Log("Locked"); // for testing
            nearDDoor = false; // keeps you from pressing and hearing sound multiple times
        }
        /*if (Input.GetKeyDown(KeyCode.P) && nearDoor == true && open == false && PlayerScoreFixRobot.doorUnlocked == true && interfaceOff == false)
        {
            Debug.Log("Key 1");
            rightkey1 = true;
            key1Text.SetActive(true);
            //wrongInput.SetActive(false);

        } 
        if (Input.GetKeyDown(KeyCode.R) && nearDoor == true && open == false && PlayerScoreFixRobot.doorUnlocked == true && interfaceOff == false && rightkey1 == true)
        {
            Debug.Log("Key 2");
            rightkey2 = true;
            key2Text.SetActive(true);
            //wrongInput.SetActive(false);

        } 
        if (Input.GetKeyDown(KeyCode.O) && nearDoor == true && open == false && PlayerScoreFixRobot.doorUnlocked == true && interfaceOff == false && rightkey1 == true && rightkey2==true)
        {
            Debug.Log("Key 3");
            rightkey3 = true;
            key3Text.SetActive(true);
            //wrongInput.SetActive(false);
            AudioSource.PlayClipAtPoint(doorSound, transform.position); // play door sound
            open = true; // says door is open
            speechBubble.SetActive(false); // destroys this so won't display again
            door.gameObject.GetComponent<Animator>().SetBool("Open", true); // tells door to do animation
            doorCollider.SetActive(false);
            //GetComponent<Animator>().SetBool("DoubleDoor_Open", true); // destroys the door for now--add animation after
            Debug.Log("Open"); // for testing
            nearDoor = false; // keeps you from pressing and hearing sound multiple times
        }*/
    }
    
    public void Animation()
    {
        Debug.Log("Animation works!");
        door.SetBool("Open", true); // tells door to do animation
        doorCollider.SetActive(false);
    }
}

