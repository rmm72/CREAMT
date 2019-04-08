using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
//Attach this script to the Zombie Prefab

	public AudioClip zombDie; //prepare the slot for ZombieDeath audioclip 

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Rock") {
			Destroy (gameObject); //Destroy the Zombie
			AudioSource.PlayClipAtPoint(zombDie, transform.position); //Play Zombie Death audio clip
			Debug.Log ("Zombie Killed");	
			ScoreCount.gscore += 1; //add score
		}

	}
}
