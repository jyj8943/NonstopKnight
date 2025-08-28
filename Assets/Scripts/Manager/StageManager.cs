using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StageManager : MonoSingleton<StageManager>
{
    [SerializeField] public List<GameObject> enemyList = new List<GameObject>();
    [SerializeField] public List<GameObject> currentEnemyList = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(-10f, 10f));
            var enemyGO = Instantiate(enemyList[0]);
            enemyGO.transform.position = pos;
            currentEnemyList.Add(enemyGO);
        }
    }
}
