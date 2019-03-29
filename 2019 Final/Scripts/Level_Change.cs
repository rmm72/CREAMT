using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class Level_Change : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        //other.name should equal the root of your Player object
        if (col.gameObject.tag == "Player")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(2);
        }
    }
}