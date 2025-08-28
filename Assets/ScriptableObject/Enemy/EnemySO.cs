using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Characters/Enemy")]
public class EnemySO : ScriptableObject
{
    [field: SerializeField] public float baseMaxHp { get; private set; }
    [field: SerializeField] public float baseMaxMp { get; private set; }
    [field: SerializeField] public float baseMaxExp { get; private set; }
    
    [field: SerializeField] public float baseAttackPoint { get; private set; }
    [field: SerializeField] public float baseWalkSpeed { get; private set; }
    
    [field: SerializeField] public float baseGoldValue { get; private set; }
    
    [field:SerializeField] public float chasingRange { get; private set; }
    [field:SerializeField] public float attackRange { get; private set; }
}
