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

    [SerializeField] public float itemPlusAttackPoint;
    [SerializeField] public float itemPlusAttackDelay;
    [SerializeField] public float itemPlusWalkSpeed;
    

    public Dictionary<ItemSO, int> playerInventory = new Dictionary<ItemSO, int>();
    
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

        itemPlusAttackPoint = 0;
        itemPlusAttackDelay = 0;
        itemPlusWalkSpeed = 0;
        
        playerInventory.Clear();
    }

    public void AddItemIntoInventory(ItemSO item)
    {
        currentGold -= item.price;

        if (playerInventory.ContainsKey(item))
        {
            playerInventory[item] += 1;
        }
        else
        {
            playerInventory.Add(item, 1);
        }
        
        UpdatePlayerStat();
    }

    private void UpdatePlayerStat()
    {
        foreach (var inventoryItem in playerInventory)
        {
            if (inventoryItem.Key.itemAbility.type == ItemAbilityType.plusAttack)
            {
                itemPlusAttackPoint = inventoryItem.Key.itemAbility.value * inventoryItem.Value;
            }
            else if (inventoryItem.Key.itemAbility.type == ItemAbilityType.plusAttackDelay)
            {
                itemPlusAttackDelay = inventoryItem.Key.itemAbility.value * inventoryItem.Value;
            }
            else if (inventoryItem.Key.itemAbility.type == ItemAbilityType.plusWalkSpeed)
            {
                itemPlusWalkSpeed = inventoryItem.Key.itemAbility.value * inventoryItem.Value;
            }
        }
    }
}
