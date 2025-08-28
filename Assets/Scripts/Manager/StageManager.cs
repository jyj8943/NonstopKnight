using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper.SerializedCollections;
using Random = UnityEngine.Random;

public class StageManager : MonoSingleton<StageManager>
{
    [SerializeField] public List<GameObject> enemyList = new List<GameObject>();
    [SerializeField] public List<GameObject> currentEnemyList = new List<GameObject>();
    
    [field: SerializeField] public StageDataSO stageData { get; private set; }
    public int currentStageLevel = 1;

    private void Start()
    {
        currentStageLevel = 1;
        StartStage();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(-10f, 10f));
            var enemyGO = Instantiate(enemyList[0]);
            enemyGO.transform.position = pos;
            currentEnemyList.Add(enemyGO);
        }

        if (currentEnemyList.Count <= 0)
        {
            currentStageLevel++;
            StartStage();
        }
    }

    private void StartStage()
    {
        foreach (var stage in stageData.stageData)
        {
            if (stage.StageLevel == currentStageLevel)
            {
                SpawnEnemy(stage.enemyNumList);
            }
        }
    }

    private void SpawnEnemy(SerializedDictionary<string, int> enemyNumList)
    {
        for (int i = 0; i < enemyNumList["Enemy_Basic"]; i++)
        {
            var pos = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(-10f, 10f));
            var enemyGO = Instantiate(enemyList[0]);
            enemyGO.transform.position = pos;
            currentEnemyList.Add(enemyGO);
        }
    }

    public float GetPercentage()
    {
        foreach (var currentStage in stageData.stageData)
        {
            if (currentStage.StageLevel == currentStageLevel)
            {
                var cur = (currentStage.enemyNumList["Enemy_Basic"] - currentEnemyList.Count);
                float percentage = (float)cur / (float)currentStage.enemyNumList["Enemy_Basic"];
                return percentage;
            }
        }

        return 0;
    }
}
