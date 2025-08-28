using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChasingState : PlayerBaseState
{
    public PlayerChasingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        
        Debug.Log("Chasing 상태로 진입합니다.");
        
        ChooseClosestEnemy();
    }

    public override void Exit()
    {
        base.Exit();
        
        Debug.Log("Chasing 상태에서 벗어납니다.");
    }

    public override void Update()
    {
        base.Update();

        MoveToShortestEnemy();
        
        if (IsShortestEnemyInAttackRange())
        {
            stateMachine.ChangeState(stateMachine.AttackState);
        }
    }
}
