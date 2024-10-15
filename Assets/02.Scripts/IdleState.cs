using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State<Player>
{
    public override void Enter(Player obj)
    {
    }

    public override void Execute(Player obj)
    {
        Debug.Log("�� �ִ���");
    }

    public override void Exit(Player obj)
    {
        if (Input.GetKeyDown(KeyCode.W))
            obj.ChangeState(PlayerState.RunState);
    }
}
