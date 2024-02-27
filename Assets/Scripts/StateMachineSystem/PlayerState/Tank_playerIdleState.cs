using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/stateMachine/PlayerState/Idle",fileName = "Tank_playerIdleState")]
public class Tank_playerIdleState : Tank_playerState
{
    public override void Enter()
    {
        base.Enter();
        player.SetZeroVelocity();
        animator.Play(stateName);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (input.Move)
        {
            stateMachine.SwitchState(typeof(Tank_playerMoveState));
        }
    }
}
