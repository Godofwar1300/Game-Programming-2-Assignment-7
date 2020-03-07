/*
* (Christopher Green)
* (Wall.cs)
* (Assignment 7)
* (This script is attatched to the wall type of object that uses Commands)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall: MonoBehaviour
{

    private void Start()
    {
        
    }

    public void On()
    {
        gameObject.SetActive(true);
    }

    public void Off()
    {
        gameObject.SetActive(false);
    }
}
