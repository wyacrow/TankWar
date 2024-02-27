using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_playerState : ScriptableObject, IState
{
    [SerializeField] protected string stateName;
    protected Animator animator;

    protected Tank_playerStateMachine stateMachine;
    protected PlayerController player;
    protected PlayerInput input;

    public void Iniatialize(Animator animator,PlayerController player,Tank_playerStateMachine stateMachine,PlayerInput input)
    {
        this.animator = animator;
        this.player = player;
        this.stateMachine = stateMachine;
        this.input = input;
    }
    public virtual void Enter()
    {
        Debug.Log("Enter " + stateName + "State");
    }

    public virtual void Exit()
    {
       
    }

    public virtual void LogicUpdate()
    {
      
    }

    public virtual void PhysicUpdate()
    {
        
    }
}
