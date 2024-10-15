using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<T> where T : class
{
    private T owenerObj;
    private State<T> currentState;

    public void SetState(T owner, State<T> obj)
    {
        owenerObj = owner;

        ChangeState(obj);    
    }

    public void Execute()
    {
        if (currentState != null)
            currentState.Execute(owenerObj);
    }

    public void ChangeState(State<T> newState)
    {

        if (newState == null)
            return;
        else
        {
            currentState.Exit(owenerObj);
        }

        currentState = newState;
        currentState.Enter(owenerObj);
    }
}
