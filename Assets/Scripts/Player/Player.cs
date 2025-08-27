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
        // 카메라 이동 확인용 코드 -> FSM으로 이동구현 되면 삭제 예정
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward;
        }
    }
}
