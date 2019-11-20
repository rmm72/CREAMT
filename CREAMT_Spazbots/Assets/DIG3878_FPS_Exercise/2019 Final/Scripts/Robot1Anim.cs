using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot1Anim : MonoBehaviour {
//attach this script to the Zombie Prefab's child that has several animation options.

	public GameObject robBroke;
	GameObject plyr;

	void Start(){
		plyr = GameObject.FindGameObjectWithTag ("Player"); 
		//Automatically find GameObject with "Player" tag
	}

	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance (gameObject.transform.position, plyr.transform.position);
		// dist variable to calculate the 3D distance (Vector3) between the Zombie and Player.

		if (dist <= 5.0f) {
			GetComponent<Animation> ().Play ("Take 001"); //Play "Attack" Animation
            robBroke.SetActive (true); //Activate the Zombie Attack audio clip
			} 

		if (dist > 5.0f) {
			GetComponent<Animation>().Play ("Zombie_Idle_01"); //Play "Idle" Animation
            robBroke.SetActive (false); //Deactivate the Zombie Attack audio clip
		}

	}

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RED_Rock(Clone)")
        {
            GetComponent<Animation>().Play("Zombie_Death_01");
            zombDed.SetActive(false);
        }
    }*/
}
