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
        player.SetVelocity(player.moveSpeed * input.xInput, player.moveSpeed * input.yInput);
        animator.Play(stateName);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(Tank_playerIdleState));
        }
    }
}
