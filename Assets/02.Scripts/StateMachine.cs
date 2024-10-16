using System.Collections.Generic;
using System;
using UnityEngine;

public class StateMachine<T> where T : Enum // 여기도 T는 Enum만 받아온다.
{
    public Dictionary<T, State<T>> stateDict = new Dictionary<T, State<T>>(); 
    public State<T> CurrentState { get; private set; }

    private Agent _agent;

    public void InitInitialize(T state, Agent agent)
    {
        _agent = agent;
        CurrentState = stateDict[state];
        CurrentState.Enter();
    }
    public void ChangeState(T changeState)
    {
        CurrentState.Exit();
        CurrentState = stateDict[changeState];
        CurrentState.Enter();
    }

    public void AddState(T stateEnum, State<T> state)
    {
        stateDict.Add(stateEnum, state);
    }
}