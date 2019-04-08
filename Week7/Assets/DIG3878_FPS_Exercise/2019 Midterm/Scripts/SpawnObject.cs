using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject cube;
    public AudioClip dingClip;
    AudioSource audioSource;
    //public GameObject sphere;

    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(cube, transform.position, transform.rotation);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(dingClip);
            Debug.Log("Dinged when C pressed.");
        }
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    Instantiate(sphere, transform.position, transform.rotation);
        //}
    }
}
