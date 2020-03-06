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

    public Wall wall;
    public ObjectTwo wallToChangeScale;

    private Command wallOn;
    private Command wallOff;
    private Command increaseScale;
    private Command decreaseScale;


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
        commandHistory = new Stack<Command>();
        onCommands = new List<Command>();
        offCommands = new List<Command>();

        wallOn = new WallOnCommand(wall);
        wallOff = new WallOffCommand(wall);

        increaseScale = new IncreaseWallSizeCommand(wallToChangeScale);
        decreaseScale = new DecreaseWallSizeCommand(wallToChangeScale);

        onCommands.Add(wallOn);
        onCommands.Add(increaseScale);

        offCommands.Add(wallOff);
        offCommands.Add(decreaseScale);

    }

    public void OnButtonWasPushed(int slot)
    {
        //onCommands[slot].Execute();
        onCommands[slot].Execute();
        commandHistory.Push(onCommands[slot]);
    }

    public void OffButtonWasPushed(int slot)
    {
        //offCommands[slot].Execute();
        //wallOff.Execute();
        offCommands[slot].Execute();
        commandHistory.Push(offCommands[slot]);
    }

    public void UndoButtonWasPressed()
    {
        //wallOn.Undo();
        if(commandHistory.Count != 0)
        {
            Debug.Log("Undoing the last command");
            Command command = commandHistory.Pop();
            command.Undo();
        }
        else
        {
            Debug.Log("You cannot undo any further!");
        }
    }


}
