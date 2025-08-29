using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemAbilityType
{
    plusAttack,
    plusAttackDelay,
    plusWalkSpeed
}

[System.Serializable]
public class ItemAbility
{
    public ItemAbilityType type;
    public float value;
}

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemSO : ScriptableObject
{
    [Header("아이템 정보")] 
    public string displayName;
    public string description;
    public Sprite icon;
    public ItemAbility itemAbility;
    public int price;
}
