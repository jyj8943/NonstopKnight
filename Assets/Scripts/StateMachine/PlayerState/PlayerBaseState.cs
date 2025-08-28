using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IState
{
    protected PlayerStateMachine stateMachine;

    protected GameObject shortestEnemy;
    
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
        ChooseClosestEnemy();
    }

    public virtual void PhysicsUpdate()
    {
        
    }

    protected bool IsEnemyInChasingRange()
    {
        // Collider[] hitCollider = Physics.OverlapSphere(stateMachine.Player.transform.position,
        //     stateMachine.Player.StatInfo.chasingRange);
        //
        // if (hitCollider.Length <= 0)
        // {
        //     Debug.Log("근처에 적이 없습니다.");
        // }
        // else
        // {
        //     foreach (var hit in hitCollider)
        //     {
        //         if (hit.CompareTag("Enemy"))
        //         {
        //             Debug.Log("Enemy 태그를 가진 콜라이더가 존재합니다.");
        //             return true;
        //         }
        //     }
        // }
        //
        // return false;

        if (StageManager.Instance.currentEnemyList.Count <= 0)
            return false;
        else
        {
            return true;
        }
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

        shortestEnemy = shortest;
    }

    protected void MoveToShortestEnemy()
    {
        if (StageManager.Instance.currentEnemyList.Count <= 0) return;
        
        Vector3 dir = (shortestEnemy.transform.position - stateMachine.Player.transform.position);
        
        stateMachine.Player.transform.Translate((dir * stateMachine.Player.StatInfo.walkSpeed) * Time.deltaTime);
    }
}
