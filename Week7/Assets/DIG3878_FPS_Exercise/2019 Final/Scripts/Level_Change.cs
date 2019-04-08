using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class Level_Change : MonoBehaviour
{
    public GameObject trig;

    void OnTriggerEnter(Collider col)
    {
        //other.name should equal the root of your Player object
        if (col.gameObject.tag == "Player" && trig.name == "NextLevel2")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(2);
        }
        else if (col.gameObject.tag == "Player" && trig.name == "NextLevel3")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(3);
        }
        else if (col.gameObject.tag == "Player" && trig.name == "NextLevel4")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(4);
        }
        else if (col.gameObject.tag == "Player" && trig.name == "NextLevel5")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(5);
        }
    }
}