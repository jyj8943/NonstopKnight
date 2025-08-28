using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatInfo : MonoBehaviour
{
    [SerializeField] public float maxHp;
    [SerializeField] public float currentHp;
    [SerializeField] public float maxMp;
    [SerializeField] public float currentMp;
    [SerializeField] public float maxExp;
    [SerializeField] public float currentExp;

    [SerializeField] public float attackPoint;
    [SerializeField] public float attackdelay;
    [SerializeField] public float walkSpeed;
    
    [SerializeField] public float currentLevel;
    [SerializeField] public float currentGold;

    [SerializeField] public float chasingRange;
    [SerializeField] public float attackRange;
    
    public void InitPlayerStats(PlayerSO playerSO)
    {
        this.maxHp = playerSO.baseMaxHp;
        currentHp = maxHp;

        maxMp = playerSO.baseMaxMp;
        currentMp = maxMp;

        maxExp = playerSO.baseMaxExp;
        currentExp = 0;

        attackPoint = playerSO.baseAttackPoint;
        attackdelay = playerSO.baseAttackDelay;
        walkSpeed = playerSO.baseWalkSpeed;

        currentLevel = playerSO.baseLevelValue;
        currentGold = playerSO.baseGoldValue;

        chasingRange = playerSO.chasingRange;
        attackRange = playerSO.attackRange;
    }
}
