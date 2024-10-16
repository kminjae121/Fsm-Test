using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State<PlayerState>
{
    private Rigidbody2D _rigid;
    private Agent _owner;

    public WalkState(Agent _onwer, StateMachine<PlayerState> state) : base(_onwer, state)
    {
        _owner = _onwer;
    }

    public override void Enter()
    {
        _rigid = _owner.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState()
    {
        Debug.Log("≥≠ ∞»∞Ì ¿÷ø¿");

        _rigid.AddForce(Vector2.up * 3 * 1, ForceMode2D.Impulse);
    }

    public override void Exit()
    {
       
    }

}
