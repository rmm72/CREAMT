using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Spazbots_Level1");
        }
        else if (Input.GetKeyDown(KeyCode.K) && Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("Spazbots_Level2");
        }
        else if (Input.GetKeyDown(KeyCode.L) && Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Spazbots_Level3");
        }
        else if (Input.GetKeyDown(KeyCode.B) && Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Spazbots_Level4");
        }
        else if (Input.GetKeyDown(KeyCode.P) && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
