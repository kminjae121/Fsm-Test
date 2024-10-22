using System;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{
    RunState,
    IdleState,
    JumpState
}
public class Player : Agent
{
    public PlayerState playerState { get; set; }
    public State<PlayerState> state;
    
    public StateMachine<PlayerState> stateMachine;

    public override void Awake()
    {
        Speed = 10;
        Hp = 10;
        AttackDamage = 20;


        stateMachine = new StateMachine<PlayerState>();

        stateMachine.AddState(PlayerState.IdleState, new IdleState(this, stateMachine));
        stateMachine.AddState(PlayerState.RunState, new WalkState(this, stateMachine));
        stateMachine.AddState(PlayerState.JumpState, new JumpState(this, stateMachine));
        stateMachine.InitInitialize(PlayerState.IdleState, this);
        base.Awake();
    }

    private void Start()
    {
    }


    private void Update()
    {
        Debug.Log(stateMachine.CurrentState);
        stateMachine.CurrentState.UpdateState();

        if (Input.GetKey(KeyCode.W))
            stateMachine.ChangeState(playerState = PlayerState.RunState);
        else if (Input.GetKeyDown(KeyCode.Space))
            stateMachine.ChangeState(playerState = PlayerState.JumpState);
        else
            stateMachine.ChangeState(playerState = PlayerState.IdleState);
    }
}
