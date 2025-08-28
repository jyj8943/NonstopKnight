using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStatInfo StatInfo { get; private set; }
    [field:SerializeField] public PlayerSO PlayerData { get; private set; }

    private PlayerStateMachine stateMachine;

    private void Awake()
    {
        StatInfo = GetComponent<PlayerStatInfo>();
        StatInfo.InitPlayerStats(PlayerData);

        stateMachine = new PlayerStateMachine(this);
    }

    private void Start()
    {
        GameManager.Instance.Player = this;
        
        stateMachine.ChangeState(stateMachine.IdleState);
    }

    private void Update()
    {
        stateMachine.HandleInput();
        stateMachine.Update();
    }
}
