using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player Plyaer { get; }

    public PlayerIdleState IdleState { get; private set; }

    public PlayerStateMachine(Player player)
    {
        this.Plyaer = player;
        
        IdleState = new PlayerIdleState(this);
    }
}
