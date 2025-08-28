using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
        
    }

    public override void Enter()
    {
        base.Enter();
        
        Debug.Log("Idle 상태로 진입했습니다.");
        
        ChooseClosestEnemy();
    }

    public override void Exit()
    {
        base.Exit();
        
        Debug.Log("Idle 상태에서 벗어납니다.");
    }

    public override void Update()
    {
        base.Update();
        
        if (IsEnemyInChasingRange())
        {
            Debug.Log("적이 근처에 있습니다.");
            stateMachine.ChangeState(stateMachine.ChasingState);
        }
    }
}
