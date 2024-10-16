using System;
using UnityEngine;

public class State<T> where T : Enum 
{
    protected Agent _agent;
    protected StateMachine<T> _stateMachine;

    public State(Agent _onwer, StateMachine<T> state)
    {
        _agent = _onwer;
        _stateMachine = state;
    }


    public virtual void UpdateState()
    {

    }

    public virtual void Enter()
    {
    }
    public virtual void Exit()
    {
    }

    public virtual void LateUpdateState()
    {

    } 
}
