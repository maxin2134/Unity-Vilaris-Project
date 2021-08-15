using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine
{
    public State currectState { get; private set; }

    public void Initialize (State startingState)
    {
        currectState = startingState;
        currectState.Enter();
    }

    public void ChangeState(State newState)
    {
        currectState.Exit();
        currectState = newState;
        currectState.Enter();
    }
}
