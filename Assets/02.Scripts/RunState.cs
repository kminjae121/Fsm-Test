using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : State<Player>
{

    public override void Enter(Player obj)
    {
        
    }

    public override void Execute(Player obj)
    {
        Debug.Log("�� �ٴ���");
    }

    public override void Exit(Player obj)
    {
        obj.ChangeState(PlayerState.IdleState);
    }
}
