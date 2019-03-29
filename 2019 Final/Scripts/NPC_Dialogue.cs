using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue : MonoBehaviour
{
    //set to trigger volume
    //tag FPS Controller as "Player"

    public GameObject speechBubble; //display above NPC's head as 3D object when in the trigger volume
    //public Material matButton; // for speechBubble to tell player what to press
    //public Material matTalking; // for speechBubble to show NPC is talking after pressing button and text is displayed
    public AudioClip hey; //sound for robot noticing you and button is displayed
    public AudioClip dialogue; // sound for robot dialogue
    public GameObject npc; //the NPC
    public GameObject npcDialogue; // the dialogue as Canvas text (can be an empty with UI background image and text or just the text)
    bool displayed = false; // says if dialogue has been displayed
    bool noticed = false; // says if NPC noticed you

    void Start()
    {
        speechBubble.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(true); // displays what button player should press as 3D object above NPC
            AudioSource.PlayClipAtPoint(hey, transform.position); // NPC wants your attention
            //npc.GetComponent<Animator>().SetBool("Noticed", true); // tells NPC animator to do noticing player animation if necessary
            Debug.Log("Noticed"); // for testing
            noticed = true; // says NPC noticed you
        } else {
                //npc.GetComponent<Animator>().SetBool("Talking", false); // tells NPC animator it is not talking
                Debug.Log("NotTalking");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(false); // speechBubble goes away
            noticed = false;
            if (displayed == true){ // if it is displayed
                npcDialogue.SetActive(false); //if the dialogue is displayed, will also go away when player leaves the volume
                //speechBubble.GetComponent<Renderer>().material = matButton; // go back to first texture on Speech Bubble
            }
        }
    }

    void Update(){
        if (Input.GetButtonDown("Fire1") && noticed == true) // if press button and NPC noticed you
        { //if the player presses the mouse button (or replace with desired key or button)
            //speechBubble.GetComponent<Renderer>().material = matTalking;
            speechBubble.SetActive(false);
            npcDialogue.SetActive(true); // display the dialogue
            AudioSource.PlayClipAtPoint(dialogue, transform.position); // play NPC dialogue
            displayed = true; // says it is displayed
            //npc.GetComponent<Animator>().SetBool("Talking", true); // tells NPC to do talking animation if necessary
            Debug.Log("Talking"); // for testing
            noticed = false; // keeps you from pressing and hearing sound multiple times
        }
    }
}
