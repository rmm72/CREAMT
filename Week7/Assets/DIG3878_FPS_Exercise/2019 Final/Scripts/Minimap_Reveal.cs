using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap_Reveal : MonoBehaviour {

    public GameObject cube;
 
    void Start()
    {
        cube.SetActive(true);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            cube.SetActive(false);
        }
    }

}

