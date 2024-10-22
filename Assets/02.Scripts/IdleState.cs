using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State<PlayerState>
{
    private Rigidbody2D _rigid;
    private Agent _owner;
    public IdleState(Agent _onwer, StateMachine<PlayerState> state) : base(_onwer, state)
    {
        _owner = _onwer;
    }

    public override void Enter()
    {
        _rigid = _owner.GetComponent<Rigidbody2D>();
        _rigid.velocity = Vector2.zero;
    }
    public override void UpdateState()
    {
        Debug.Log("æ∆¿’ª–");
        
    }

    public override void Exit()
    {
        
    }
}
