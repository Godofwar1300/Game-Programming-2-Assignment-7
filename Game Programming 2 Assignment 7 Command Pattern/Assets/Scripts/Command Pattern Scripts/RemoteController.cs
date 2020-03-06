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

    public Wall wall;
    private Command wallOn;
    private Command wallOff;


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
        wallOn = new WallOnCommand(wall);
        wallOff = new WallOffCommand(wall);
    }

    public void OnButtonWasPushed()
    {
        //onCommands[slot].Execute();
        wallOn.Execute();
    }

    public void OffButtonWasPushed()
    {
        //offCommands[slot].Execute();
        wallOff.Execute();
    }

    public void UndoButtonWasPressed()
    {
        wallOn.Undo();
    }


}
