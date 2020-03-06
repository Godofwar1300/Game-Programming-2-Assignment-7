using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    // abstract Execute() method that will exectue/run whatever command is selected or chosen.
    void Execute();

    // abstract Undo() method that will undo/redo/decrement whatever command was previously chosen /or rexecuted.
    void Undo();
}
