using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour {

    /*List<GameObject> cubes = new List<GameObject>();

    public GameObject appCube;
    public GameObject oraCube;
    public GameObject lemCube;
    public GameObject instruct;
    //public int maxCube = 7;
    //public AudioClip dingClip;
    //AudioSource audioSource;

    void Update()
    {
        //StartCoroutine(DelayTheBox());
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(oraCube, transform.position, transform.rotation);
            instruct.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(appCube, transform.position, transform.rotation);
            instruct.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(lemCube, transform.position, transform.rotation);
            instruct.SetActive(false);
        }
        //audioSource = GetComponent<AudioSource>();
        //audioSource.PlayOneShot(dingClip);
        Debug.Log("Fruit cube spawned.");
    }

    /*IEnumerator DelayTheBox()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        if (cubes.Count < maxCube)
        {
            GameObject cube = (GameObject)Instantiate(cubePrefab, transform.position, transform.rotation);
            cubes.Add(cube);
        }
    }*/
}