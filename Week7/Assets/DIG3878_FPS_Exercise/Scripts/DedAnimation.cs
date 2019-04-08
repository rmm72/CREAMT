using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedAnimation : MonoBehaviour {

    public GameObject zombAtt;
    public AudioClip zombDie;
    bool zombieKilled = false;
    GameObject plyr;

    // Use this for initialization
    void Start () {
        plyr = GameObject.FindGameObjectWithTag("Player");
        //Automatically find GameObject with "Player" tag
    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position, plyr.transform.position);
        // dist variable to calculate the 3D distance (Vector3) between the Zombie and Player.

        if (dist <= 5.0f && zombieKilled == false)
        {
            GetComponent<Animation>().Play("Zombie_Attack_01"); //Play "Attack" Animation
            zombAtt.SetActive(true); //Activate the Zombie Attack audio clip
        }

        if (dist > 5.0f && zombieKilled == false)
        {
            GetComponent<Animation>().Play("Zombie_Idle_01"); //Play "Idle" Animation
            zombAtt.SetActive(false); //Deactivate the Zombie Attack audio clip
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock")
        {
            GetComponent<Animation>().Play("Zombie_Death_01");
            Destroy(gameObject, 1.2f); //Destroy the Zombie, delay it by 1,2 secs
            AudioSource.PlayClipAtPoint(zombDie, transform.position); //Play Zombie Death audio clip
            Debug.Log("Zombie Killed");
            ScoreCount.gscore += 1; //add score
            zombieKilled = true;
        }

    }
}
