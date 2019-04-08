using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public GameObject goalGroup;
    public GameObject zone;

    /*public void AddScore()
    {
        ScoreCount.gscore += 1;
    }*/

    void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.name == "CannonBall(Clone)")
        {
            ScoreCount.gscore ++;
            StartCoroutine(DelayGoalDisp());
        }
    }

    IEnumerator DelayGoalDisp()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        goalGroup.SetActive(false);
        zone.SetActive(false);
    }
}
