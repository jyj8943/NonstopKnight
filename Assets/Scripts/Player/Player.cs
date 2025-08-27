using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        // 카메라 이동 확인용 코드 -> FSM으로 이동구현 되면 삭제 예정
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward;
        }
    }
}
