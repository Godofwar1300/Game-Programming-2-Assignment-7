/*
* (Christopher Green)
* (RemoteController.cs)
* (Assignment 7)
* (This is the invoker script that takes care of the actions of the buttons and thet undo button)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteController : MonoBehaviour
{

    //Command slot1;
    //Command slot2;

    //Command[] onCommands;
    //Command[] offCommands;

    Stack<Command> commandHistory;

    List<Command> onCommands;
    List<Command> offCommands;

    List<Command> growCommands;
    List<Command> shrinkCommands;

    private Wall[] wall;
    private ObjectTwo[] wallToChangeScale;

    // private Command[] wallOn;
    //private Command[] wallOff;
    private List<Command> wallOn;
    private List<Command> wallOff;

    //private Command increaseScale;
    //private Command decreaseScale;

    private List<Command> increaseScale;
    private List<Command> decreaseScale;


    //public RemoteController()
    //{
    //    onCommands = new Command[1];
    //    offCommands = new Command[1];
    //    commandHistory = new Stack<Command>();
    //}

    //public void setCommand(int slot, Command onCommand, Command offCommand)
    //{
    //    //slot1 = command;

    //    onCommands[slot] = onCommand;
    //    offCommands[slot] = offCommand;

    //}

    private void Start()
    {

        wall = FindObjectsOfType<Wall>();
        wallToChangeScale = FindObjectsOfType<ObjectTwo>();

        commandHistory = new Stack<Command>();

        onCommands = new List<Command>();
        offCommands = new List<Command>();
        wallOn = new List<Command>();
        wallOff = new List<Command>();

        growCommands = new List<Command>();
        shrinkCommands = new List<Command>();
        increaseScale = new List<Command>();
        decreaseScale = new List<Command>();

        for (int i = 0; i < wall.Length; i++)
        {
            //Debug.Log("Index is : " + i);
            wallOn.Add(new WallOnCommand(wall[i]));
            wallOff.Add(new WallOffCommand(wall[i]));
        }

        for (int j = 0; j < wallOn.Count; j++)
        {
            onCommands.Add(wallOn[j]);
        }
        for (int k = 0; k < wallOff.Count; k++)
        {
            offCommands.Add(wallOff[k]);
        }

        for (int i = 0; i < wallToChangeScale.Length; i++)
        {
            //Debug.Log("Index is : " + i);
            growCommands.Add(new IncreaseWallSizeCommand(wallToChangeScale[i]));
            shrinkCommands.Add(new DecreaseWallSizeCommand(wallToChangeScale[i]));
        }

        for (int j = 0; j < growCommands.Count; j++)
        {
            increaseScale.Add(growCommands[j]);
        }
        for (int k = 0; k < shrinkCommands.Count; k++)
        {
            decreaseScale.Add(shrinkCommands[k]);
        }
    }

    public void Update()
    {
        Debug.Log("The total amount of Commands in commandHistory: " + commandHistory.Count);
    }

    public void OnButtonWasPushed()
    {
        //onCommands[slot].Execute();
        foreach (Command command in onCommands)
        {
            command.Execute();
            commandHistory.Push(command);
        }
        //onCommands[slot].Execute();
        //commandHistory.Push(onCommands[slot]);
    }

    public void OffButtonWasPushed()
    {
        //offCommands[slot].Execute();
        //wallOff.Execute();
        //offCommands[slot].Execute();
        //commandHistory.Push(offCommands[slot]);

        foreach (Command command in offCommands)
        {
            command.Execute();
            commandHistory.Push(command);
        }
    }

    public void GrowButtonWasPushed()
    {
        foreach (Command command in increaseScale)
        {
            command.Execute();
            commandHistory.Push(command);
        }
    }
    public void ShrinkButtonWasPushed()
    {
        foreach (Command command in decreaseScale)
        {
            command.Execute();
            commandHistory.Push(command);
        }
    }

    public void UndoButtonWasPressed()
    {
        //wallOn.Undo();
        if (commandHistory.Count != 0)
        {
            Debug.Log("Undoing the last command");
            Debug.Log("The total amount of Commands in commandHistory: " + commandHistory.Count);


            for (int i = 0; i <= commandHistory.Count; i++)
            {
                Command command = commandHistory.Pop();
                Debug.Log("The command that was popped was: " + command);
                command.Undo();
            }

            //Command command = commandHistory.Pop();
            //command.Undo();
        }
        else
        {
            Debug.Log("You cannot undo any further!");
        }
    }
}
