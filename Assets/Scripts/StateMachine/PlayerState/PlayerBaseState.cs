using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IState
{
    protected PlayerStateMachine stateMachine;

    // protected GameObject shortestEnemy;
    
    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    
    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }

    public virtual void HandleInput()
    {
        
    }

    public virtual void Update()
    {
        
    }

    public virtual void PhysicsUpdate()
    {
        
    }

    protected bool IsEnemyInChasingRange()
    {
        if (StageManager.Instance.currentEnemyList.Count <= 0)
            return false;
        else
        {
            return true;
        }
    }

    protected bool IsShortestEnemyInAttackRange()
    {
        var dis = (stateMachine.Player.transform.position - stateMachine.targetEnemy.transform.position).sqrMagnitude;
        if (dis <= (stateMachine.Player.StatInfo.attackRange * stateMachine.Player.StatInfo.attackRange))
        {
            return true;
        }

        return false;
    }

    protected void ChooseClosestEnemy()
    {
        if (StageManager.Instance.currentEnemyList.Count <= 0) return;
        
        var shortest = StageManager.Instance.currentEnemyList[0];
        var shortestDist = (stateMachine.Player.transform.position - shortest.transform.position).sqrMagnitude;
        foreach (var enemies in StageManager.Instance.currentEnemyList)
        {
            float dist = (stateMachine.Player.transform.position - enemies.transform.position).sqrMagnitude;

            if (dist <= shortestDist)
            {
                shortest = enemies;
            }
        }

        stateMachine.targetEnemy = shortest;
    }

    protected void MoveToShortestEnemy()
    {
        if (StageManager.Instance.currentEnemyList.Count <= 0) return;
        
        Vector3 dir = (stateMachine.targetEnemy.transform.position - stateMachine.Player.transform.position);
        
        stateMachine.Player.transform.Translate((dir * stateMachine.Player.StatInfo.walkSpeed) * Time.deltaTime);
    }
}
