using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightHint : MonoBehaviour {

    public GameObject speechBubble;
    public AudioClip dialogue;

	// Use this for initialization
	void Start () {
        speechBubble.SetActive(false);
	}

    // Update is called once per frame
    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            speechBubble.SetActive(true);
            AudioSource.PlayClipAtPoint(dialogue, transform.position);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(speechBubble);
        }
    }
}
