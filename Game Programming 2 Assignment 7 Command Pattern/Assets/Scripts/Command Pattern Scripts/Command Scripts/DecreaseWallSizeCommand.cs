using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseWallSizeCommand : Command
{

    ObjectTwo objectTwo;

    //private Vector3 scaleChange;

    public DecreaseWallSizeCommand(ObjectTwo newObjectTwo)
    {
        objectTwo = newObjectTwo;
    }

    public void Execute()
    {
        // move this to the ObjectTwo class
        objectTwo.Shrink();
        //scaleChange = new Vector3(0.5f, 0.5f, 0.5f);
        //wall.transform.localScale += scaleChange;
    }

    public void Undo()
    {
        // Move this to the ObjectTwo class
        objectTwo.Grow();
        //scaleChange = new Vector3(0.5f, 0.5f, 0.5f);
        //wall.transform.localScale -= scaleChange;
    }
}
