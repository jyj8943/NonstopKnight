using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private Player player;

    public Player Player
    {
        get { return player; }
        set { player = value; }
    }
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        
    }
}
