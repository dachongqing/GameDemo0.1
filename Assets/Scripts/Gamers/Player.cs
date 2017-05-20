﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, NPC {

	[SerializeField]private int actionPoint;

    private int[] abilityInfo;

	[SerializeField] private int[] xyz;

    private String playerName;

    private bool roundOver;

    public int getActionPoint()
    {
        return actionPoint;
    }

    public int[] getAbilityInfo()
    {
        return abilityInfo;
    }

    public int[] getCurrentRoom()
    {
        return xyz;
    }

    public void setCurrentRoom(int[] xyz)
    {
        this.xyz = xyz;
    }

    public string getName()
    {
        return playerName;
    }

    public bool isDead()
    {
        return false;
    }

    public bool isPlayer()
    {
        return true;
    }

    public bool isRoundOver()
    {
        return roundOver;
    }

    public void endRound() {
        this.roundOver = true;
     }

    public bool isWaitPlayer()
    {
        return true;
    }

    public void roundStart()
    {
       //可以roll点
    }

    public void updateActionPoint(int actionPoint)
    {
        this.actionPoint = actionPoint;
    }

    // Use this for initialization
    void Start () {
		//游戏一开始 所处的房间 默认房间的坐标为 0,0,0
		int[] roomXYZ={0,0,0};
		setCurrentRoom(roomXYZ);
        abilityInfo = new int[] {5,3,6,8 };

        Debug.Log ("Player.cs Start() 玩家进入默认房间");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
