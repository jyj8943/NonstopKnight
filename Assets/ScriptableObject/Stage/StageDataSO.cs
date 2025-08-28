using System;
using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;

[System.Serializable]
public class StageDataList
{
    public int StageLevel;
    [SerializeField] public SerializedDictionary<string, int> enemyNumList = new SerializedDictionary<string, int>();
}

[System.Serializable]
[CreateAssetMenu(fileName = "StageDataSO", menuName = "Stage")]
public class StageDataSO : ScriptableObject
{
    [SerializeField] public List<StageDataList> stageData = new List<StageDataList>();
}
