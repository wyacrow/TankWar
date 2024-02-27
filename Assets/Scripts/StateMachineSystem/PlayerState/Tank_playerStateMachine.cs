using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class Tank_playerStateMachine : StateMachine
{
    //����һ�����������洢��player��ӵ�״̬������Ҫһ����������
    [SerializeField] Tank_playerState[] states;

    Animator animator;
    PlayerInput input;
    PlayerController player;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        input = GetComponent<PlayerInput>();
        player = GetComponent<PlayerController>();

        stateTable = new Dictionary<System.Type, IState>(states.Length);

        foreach(Tank_playerState state in states)
        {
            state.Iniatialize(animator,player, this, input);
            stateTable.Add(state.GetType(), state);
        }
    }

    private void Start()
    {
        switchOn(stateTable[typeof(Tank_playerIdleState)]);
    }

}
