using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour {

    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;

	public void HitButton()
    {
        Debug.Log("Pressed button.");
    }

    public void HitButtonCUBE()
    {
        cube.SetActive(true);
    }
    public void HitButtonSPHERE()
    {
        cube.SetActive(true);
    }
    public void HitButtonCAPSULE()
    {
        cube.SetActive(true);
    }
}
