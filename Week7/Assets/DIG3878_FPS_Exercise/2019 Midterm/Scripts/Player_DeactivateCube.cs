using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_DeactivateCube : MonoBehaviour {

    // Use this for initialization

    public bool cubeOff = false;
    public GameObject cube;
    public GameObject win;

    void OnCollisionEnter (Collision col) {
		if ((col.gameObject.name == "Cube") && cubeOff==false)
        {
            cube.SetActive(false);
            cubeOff = true;
            win.SetActive(true);
        }
        else if ((col.gameObject.name == "Cube") && cubeOff==true)
        {
            cube.SetActive(true);
            cubeOff = false;
            win.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
