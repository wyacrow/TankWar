using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    //����״̬
    void Enter();
    //�˳�״̬
    void Exit();
    //״̬�ĸ���
    void LogicUpdate();
    void PhysicUpdate();


}