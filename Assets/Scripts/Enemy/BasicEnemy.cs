using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public BasicEnemyStatInfo StatInfo { get; private set; }
    [field:SerializeField] public EnemySO BasicEnemyData { get; private set; }

    private void Awake()
    {
        StatInfo = GetComponent<BasicEnemyStatInfo>();
        StatInfo.InitPlayerStats(BasicEnemyData);
    }

    private void Start()
    {
        StatInfo.OnDie += OnDie;
    }

    private void OnDie()
    {
        StageManager.Instance.currentEnemyList.Remove(this.gameObject);
        GameManager.Instance.Player.StatInfo.currentGold += StatInfo.dropGold;
        GameManager.Instance.Player.StatInfo.currentExp += StatInfo.dropExp;
        Destroy(this.gameObject);
    }
}
