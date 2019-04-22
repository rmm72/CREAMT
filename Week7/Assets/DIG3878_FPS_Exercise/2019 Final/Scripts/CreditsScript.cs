using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScript : MonoBehaviour {

    public GameObject quitButton;

	// Use this for initialization
	void Start () {
        quitButton.SetActive(true);
	}
	
	// Update is called once per frame
	public void OnTriggerEnter2D (Collision col) {
		if (col.gameObject.tag == "Logo")
        {
            quitButton.SetActive(false);
        }
	}
}
