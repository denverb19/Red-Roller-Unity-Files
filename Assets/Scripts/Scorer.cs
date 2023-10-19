using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int currentScore = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "AlreadyHit" && other.gameObject.tag != "Ground")
        {
            currentScore += 1;
            if (currentScore <= 1)
            {
                Debug.Log("You have bumped into things " + currentScore + " time!");
            }
            else
            {
                Debug.Log("You have bumped into things " + currentScore + " times!");
            }
        }
    }
}