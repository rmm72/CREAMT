using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchersVaried : MonoBehaviour {

    public GameObject appleLauncher;
    public GameObject orangeLauncher;
    public GameObject lemonLauncher;
    public GameObject appBall;
    public GameObject oraBall;
    public GameObject lemBall;
    float ballSpeed = 15f;
    public GameObject appleSpawner;
    public GameObject orangeSpawner;
    public GameObject lemonSpawner;

    public void goAUP()
    {
        appleLauncher.transform.Rotate(Vector3.forward * 5);
    }
    
    public void goOUP()
    {
        orangeLauncher.transform.Rotate(Vector3.forward * 5);
    }

    public void goLUP()
    {
        lemonLauncher.transform.Rotate(Vector3.forward * 5);
    }

    public void goADOWN()
    {
        appleLauncher.transform.Rotate(Vector3.back * 5);
    }

    public void goODOWN()
    {
        orangeLauncher.transform.Rotate(Vector3.back * 5);
    }

    public void goLDOWN()
    {
        lemonLauncher.transform.Rotate(Vector3.back * 5);
    }

    public void goALEFT()
    {
        appleLauncher.transform.Rotate(Vector3.left * 5);
    }

    public void goOLEFT()
    {
        orangeLauncher.transform.Rotate(Vector3.left * 5);
    }

    public void goLLEFT()
    {
        lemonLauncher.transform.Rotate(Vector3.left * 5);
    }

    public void goARIGHT()
    {
        appleLauncher.transform.Rotate(Vector3.right * 5);
    }

    public void goORIGHT()
    {
       orangeLauncher.transform.Rotate(Vector3.right * 5);
    }

    public void goLRIGHT()
    {
        lemonLauncher.transform.Rotate(Vector3.right * 5);
    }

    public void ThrowBallApp()
    {
        GameObject theBall = (GameObject)Instantiate(appBall, appleSpawner.transform.position + appleSpawner.transform.forward, appleSpawner.transform.rotation);
        theBall.GetComponent<Rigidbody>().AddForce(appleSpawner.transform.forward * ballSpeed, ForceMode.Impulse);
    }

    public void ThrowBallOra()
    {
        GameObject theBall = (GameObject)Instantiate(oraBall, orangeSpawner.transform.position + orangeSpawner.transform.forward, orangeSpawner.transform.rotation);
        theBall.GetComponent<Rigidbody>().AddForce(orangeSpawner.transform.forward * ballSpeed, ForceMode.Impulse);
    }

    public void ThrowBallLem()
    {
        GameObject theBall = (GameObject)Instantiate(lemBall, lemonSpawner.transform.position + lemonSpawner.transform.forward, lemonSpawner.transform.rotation);
        theBall.GetComponent<Rigidbody>().AddForce(lemonSpawner.transform.forward * ballSpeed, ForceMode.Impulse);
    }
}
