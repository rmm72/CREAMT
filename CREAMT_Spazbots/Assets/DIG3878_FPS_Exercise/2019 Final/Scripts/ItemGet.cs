using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    //set to trigger volume
    //tag FPS Controller as "Player"

    public GameObject pickupBubble; //display in Canvas when in the trigger volume
    //public Material matButton; // for speechBubble to tell player what to press
    //public Material matTalking; // for speechBubble to show NPC is talking after pressing button and text is displayed
    //public AudioClip hey; //sound for near door
    public AudioClip itemSound; // sound for item
    public GameObject item; //the collectible item
    bool itemPicked = false; // says if item been picked
    bool nearItem = false; // says if near item

    void Start()
    {
        pickupBubble.SetActive(false);
        item.SetActive(true);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            pickupBubble.SetActive(true); // displays what button player should press as Canvas UI
            //AudioSource.PlayClipAtPoint(hey, transform.position); // Can have sound if you want when displayed
            Debug.Log("Near Item"); // for testing
            nearItem = true; // says door display on
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            pickupBubble.SetActive(false); // speechBubble goes away
            /*if (displayed == true)
            { // if it is displayed
                npcDialogue.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
                speechBubble.GetComponent<Renderer>().material = matButton; // go back to first texture on Speech Bubble
            }*/
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && nearItem == true && itemPicked == false) // if press button and NPC noticed you
        { //if the player presses the mouse button (or replace with desired key or button)
            //speechBubble.GetComponent<Renderer>().material = matTalking;
            AudioSource.PlayClipAtPoint(itemSound, transform.position); // play NPC dialogue
            itemPicked = true; 
            pickupBubble.SetActive(false);
            //door.GetComponent<Animator>().SetBool("Open", true); // tells door to do talking animation if necessary
            item.SetActive(false);
            Debug.Log("Open"); // for testing
            nearItem = false; // keeps you from pressing and hearing sound multiple times
            ItemInventory.gscore++;
        }
    }
}
