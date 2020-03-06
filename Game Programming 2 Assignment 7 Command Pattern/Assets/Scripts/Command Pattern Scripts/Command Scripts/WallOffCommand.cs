using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOffCommand : Command
{
    // Reference to the device/reciever
    Wall wall;

    public WallOffCommand(Wall newWall) //Device parameter
    {
        // this.device = deviceParameter
        wall = newWall;
    }

    public void Execute()
    {
        // device.functionNameToExecute
        wall.Off();
    }

    public void Undo()
    {
        // device.functionNameToUndo
        wall.On();
    }
}
