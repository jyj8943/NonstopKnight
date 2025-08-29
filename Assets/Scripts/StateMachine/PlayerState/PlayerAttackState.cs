using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerBaseState
{
    private float attackTimer = 0;
    
    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        base.Enter();
        
        Debug.Log("Attack 상태로 진입합니다.");
    }

    public override void Exit()
    {
        base.Exit();
        
        Debug.Log("Attack 상태에서 벗어납니다.");
    }

    public override void Update()
    {
        base.Update();
        
        AttackTargetEnemy();
        
        if (stateMachine.targetEnemy == null)
        {
            stateMachine.ChangeState(stateMachine.IdleState);
        }
    }

    private void AttackTargetEnemy()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer >= (stateMachine.Player.StatInfo.attackdelay - stateMachine.Player.StatInfo.itemPlusAttackDelay))
        {
            stateMachine.targetEnemy.GetComponent<BasicEnemyStatInfo>().GetDamage(stateMachine.Player.StatInfo.attackPoint 
                + stateMachine.Player.StatInfo.itemPlusAttackPoint);
            attackTimer = 0;
        }
    }
}
