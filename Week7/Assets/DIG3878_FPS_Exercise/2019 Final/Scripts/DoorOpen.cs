using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    //set to trigger volume
    //tag FPS Controller as "Player"

    public GameObject speechBubble; //display in Canvas when in the trigger volume
    //public Material matButton; // for speechBubble to tell player what to press
    //public Material matTalking; // for speechBubble to show NPC is talking after pressing button and text is displayed
    //public AudioClip hey; //sound for near door
    public AudioClip doorSound; // sound for door
    public GameObject door; //the door object
    //public GameObject ceiling;
    //public GameObject npcDialogue; // the dialogue as Canvas text (can be an empty with UI background image and text or just the text)
    bool open = false; // says if door has been opened
    bool nearDoor = false; // says if near door

    void Start()
    {
        speechBubble.SetActive(false);
        door.SetActive(true);
        //ceiling.SetActive(true);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(true); // displays what button player should press as Canvas UI
            //AudioSource.PlayClipAtPoint(hey, transform.position); // Can have sound if you want when displayed
            Debug.Log("Near Door"); // for testing
            nearDoor = true; // says door display on
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(false); // speechBubble goes away
            /*if (displayed == true)
            { // if it is displayed
                npcDialogue.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
                speechBubble.GetComponent<Renderer>().material = matButton; // go back to first texture on Speech Bubble
            }*/
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && nearDoor == true && open == false) // if press button and NPC noticed you
        { //if the player presses the mouse button (or replace with desired key or button)
            //speechBubble.GetComponent<Renderer>().material = matTalking;
            AudioSource.PlayClipAtPoint(doorSound, transform.position); // play NPC dialogue
            open = true; // says door is open
            speechBubble.SetActive(false); // destroys this so won't display again
            //door.GetComponent<Animator>().SetBool("Open", true); // tells door to do talking animation if necessary
            door.SetActive(false);
            Debug.Log("Open"); // for testing
            nearDoor = false; // keeps you from pressing and hearing sound multiple times
            //ceiling.SetActive(false);
        }
    }
}
