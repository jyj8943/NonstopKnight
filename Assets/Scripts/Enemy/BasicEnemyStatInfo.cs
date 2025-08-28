using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyStatInfo : MonoBehaviour
{
    [SerializeField] public float maxHp;
    [SerializeField] public float currentHp;
    [SerializeField] public float maxMp;
    [SerializeField] public float currentMp;
    [SerializeField] public float dropExp;
    
    [SerializeField] public float attackPoint;
    [SerializeField] public float walkSpeed;
    
    [SerializeField] public float dropGold;
    
    [SerializeField] public float chasingRange;
    [SerializeField] public float attackRange;

    public bool isDie = false;
    public event Action OnDie;
    
    public void InitPlayerStats(EnemySO basicEnemySO)
    {
        this.maxHp = basicEnemySO.baseMaxHp;
        currentHp = maxHp;

        maxMp = basicEnemySO.baseMaxMp;
        currentMp = maxMp;

        dropExp = basicEnemySO.baseMaxExp;

        attackPoint = basicEnemySO.baseAttackPoint;
        walkSpeed = basicEnemySO.baseWalkSpeed;
        
        dropGold = basicEnemySO.baseGoldValue;

        chasingRange = basicEnemySO.chasingRange;
        attackRange = basicEnemySO.attackRange;

        isDie = false;
    }

    public void GetDamage(float damage)
    {
        if (currentHp == 0)
            return;

        currentHp = Mathf.Max(currentHp - damage, 0);
        Debug.Log(damage + "만큼의 피해를 주었습니다.");

        if (currentHp == 0)
        {
            isDie = true;
            OnDie?.Invoke();
        }
    }
}
