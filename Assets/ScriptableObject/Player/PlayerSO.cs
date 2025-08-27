using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Characters/Player")]
public class PlayerSO : ScriptableObject
{
    // 플레이어가 레벨이 올라감에 따라 최대 체력, 최대 마나, 최대 경험치 등도 증가
    [field: SerializeField] public float baseMaxHp { get; private set; }
    [field: SerializeField] public float baseMaxMp { get; private set; }
    [field: SerializeField] public float baseMaxExp { get; private set; }
    
    [field: SerializeField] public float baseAttackPoint { get; private set; }
    [field: SerializeField] public float baseWalkSpeed { get; private set; }
    
    [field: SerializeField] public float baseLevelValue { get; private set; }
    [field: SerializeField] public float baseGoldValue { get; private set; }
}
