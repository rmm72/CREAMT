using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLemon : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock" && col.gameObject.name == "L_Ball(Clone)")
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
