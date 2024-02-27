using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    //��ǰ״̬
    IState currentState;

    //�����ֵ�����ȡ״̬�������״̬
    protected Dictionary<System.Type, IState> stateTable;

    private void Update()
    {
        //ÿһ֡�������
        currentState.LogicUpdate();
    }
    private void FixedUpdate()
    {
        //ÿһ֡�������
        currentState.PhysicUpdate();
    }

    //�л�״̬��һ��ʼ��
    protected void switchOn(IState newstate)
    {
        currentState = newstate;
        currentState.Enter();
        //�����µ�״̬���������µ�״̬
    }

    //�л�״̬
    public void SwitchState(IState newstate)
    {
        currentState.Exit();
        switchOn(newstate);
        //���˳�ԭ�ȵ�״̬���������µ�״̬
    }

    //��״̬�л���������һ�����أ������ֵ䣬ͨ����״̬���������л�״̬
    public void SwitchState(System.Type newstatetype)
    {
        SwitchState(stateTable[newstatetype]);
    }

}
