using System;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{
    RunState = 0,
    IdleState,
}
public class Player : MonoBehaviour
{
    private float speed;

    public PlayerState playerState { get; set; }
    private State<Player>[] state;

    private StateMachine<Player> stateMachine; 

    private void Awake()
    {
        stateMachine = new StateMachine<Player>();
        state = new State<Player>[2];

        state[(int)PlayerState.RunState] = new RunState();
        state[(int)PlayerState.IdleState] = new IdleState();
    }

    private void Start()
    {
        stateMachine.SetState(this, state[(int)PlayerState.IdleState]);
    }


    private void Update()
    {
        stateMachine.Execute();
    }

    public void ChangeState(PlayerState Currentstate)
    {
        stateMachine.ChangeState(state[(int)Currentstate]);
    }
}
