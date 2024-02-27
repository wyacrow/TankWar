using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

[CreateAssetMenu(menuName = "Data/stateMachine/PlayerState/Move", fileName = "Tank_playerMoveState")]
public class Tank_playerMoveState : Tank_playerState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log(input.xInput + "xInput" + input.yInput + "yInput");
        //ÒÆ¶¯ÓÐbug
        animator.Play(stateName);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        Debug.Log(input.xInput + "xInput" + input.yInput + "yInput");
        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(Tank_playerIdleState));
        }
    }
    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
        player.SetVelocity(player.moveSpeed * input.xInput, player.moveSpeed * input.yInput);
    }
}
