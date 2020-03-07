/*
* (Christopher Green)
* (WallOnCommand.cs)
* (Assignment 7)
* (This is a command script that handles turning on the appropriate object)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOnCommand : Command
{

    // Reference to the device/reciever
    Wall wall;

    public WallOnCommand(Wall newWall) //Device parameter
    {
        // this.device = deviceParameter
        wall = newWall;
    }

    public void Execute()
    {
        // device.functionNameToExecute
        Debug.Log("The Object should Appear");
        wall.On();
    }

    public void Undo()
    {
        // device.functionNameToUndo
        Debug.Log("The Object should disappear");
        wall.Off();
    }
}
