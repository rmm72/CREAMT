using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    public Transform player;
    //private Vector3 offset;

    // Use this for initialization
    void Start () {
        //offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        //transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);

        //transform.position = player.transform.position + offset;
    }

}

