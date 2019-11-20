using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventory : MonoBehaviour {
    //create GameManager and attach this script

    public static int gscore = 0;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    private void Start()
    {
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
    }

    void Update()
    {
        if (gscore == 0)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
        }
        else if (gscore == 1)
        {
            item1.SetActive(true);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
        }
        else if (gscore == 2)
        {
            item1.SetActive(true);
            item2.SetActive(true);
            item3.SetActive(false);
            item4.SetActive(false);
        }
        else if (gscore == 3)
        {
            item1.SetActive(true);
            item2.SetActive(true);
            item3.SetActive(true);
            item4.SetActive(false);
        }
        else if (gscore == 4)
        {
            item1.SetActive(true);
            item2.SetActive(true);
            item3.SetActive(true);
            item4.SetActive(true);
        }
    }

}
