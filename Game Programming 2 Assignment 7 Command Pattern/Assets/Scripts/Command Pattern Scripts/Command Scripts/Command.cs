/*
* (Christopher Green)
* (Command.cs)
* (Assignment 7)
* (This is the interface that "creates" the Execute and Undo methods)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    // method that will exectue/run whatever command is selected or chosen.
    void Execute();

    // method that will undo/redo/decrement whatever command was previously chosen /or rexecuted.
    void Undo();
}
