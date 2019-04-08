using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap_Open : MonoBehaviour
{

    public GameObject player;
    public Camera plyrCamera;
    public Camera mapCamera;
    public GameObject closeMap;
    public GameObject bolt;

    // Use this for initialization
    void Start()
    {
        plyrCamera.enabled = true;
        mapCamera.enabled = false;
        closeMap.SetActive(false);
        bolt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && (plyrCamera.enabled == true && mapCamera.enabled == false))
        {
            plyrCamera.enabled = true;
            mapCamera.enabled = true;
            closeMap.SetActive(true);
            bolt.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.M) && (mapCamera.enabled == true && plyrCamera.enabled == true))
        {
            plyrCamera.enabled = true;
            mapCamera.enabled = false;
            closeMap.SetActive(false);
            bolt.SetActive(true);
        }
    }
}
