using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsVaried : MonoBehaviour {

    public GameObject buttonGroup;
    public GameObject appleGroup;
    public GameObject orangeGroup;
    public GameObject lemonGroup;
    public GameObject back;

    public void HitButtonAPPLE()
    {
        Debug.Log("Apple chosen.");
        buttonGroup.SetActive(false);
        appleGroup.SetActive(true);
        back.SetActive(true);
    }

    public void HitButtonORANGE()
    {
        Debug.Log("Orange chosen.");
        buttonGroup.SetActive(false);
        orangeGroup.SetActive(true);
        back.SetActive(true);
    }

    public void HitButtonLEMON()
    {
        Debug.Log("Lemon chosen.");
        buttonGroup.SetActive(false);
        lemonGroup.SetActive(true);
        back.SetActive(true);
    }

    public void HitButtonBACK()
    {
        Debug.Log("Back pressed.");
        buttonGroup.SetActive(true);
        appleGroup.SetActive(false);
        orangeGroup.SetActive(false);
        lemonGroup.SetActive(false);
        back.SetActive(false);
    }
}
