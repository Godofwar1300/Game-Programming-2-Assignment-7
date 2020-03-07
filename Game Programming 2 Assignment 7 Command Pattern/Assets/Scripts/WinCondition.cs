/*
* (Christopher Green)
* (WinCondition.cs)
* (Assignment 7)
* (This is a script that is attatched the the "coin" and adds a coin)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        AddScore.totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            AddScore.totalScore += 1;
        }
    }

}
