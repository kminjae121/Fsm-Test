using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State<PlayerState>
{
    public JumpState(Agent _onwer, StateMachine<PlayerState> state) : base(_onwer, state)
    {
    }

    public override void Enter()
    {
        Debug.Log("점프하는중");

        _stateMachine.ChangeState(PlayerState.IdleState);
    }

    public override void UpdateState()
    {
            
    }

    public override void Exit()
    {
        
    }
}
