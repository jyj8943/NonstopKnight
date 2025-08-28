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
    }
}
