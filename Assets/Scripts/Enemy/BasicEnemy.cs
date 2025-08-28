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
}
