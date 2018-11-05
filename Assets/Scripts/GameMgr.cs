using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    void Awake()
    {
        Stat.Init();
    }
    void Start()
    {
        Stat.d[eStat.maxMeter].Value = 1000;
        Stat.d[eStat.moneyPerMeter].Value = 10;
        Stat.d[eStat.maxStamina].Value = 100;
        Stat.d[eStat.staminaRecovery].Value = 1;
        Stat.d[eStat.view].Value = 0;
        Stat.d[eStat.diveTime].Value = 0;
        Stat.d[eStat.temperature].Value = 0;
        Stat.d[eStat.weaponLv].Value = 0;
        Stat.d[eStat.maxHealth].Value = 0;
        Stat.d[eStat.maxOxygen].Value = 0;
        Stat.d[eStat.yAcceleration].Value = 0;
    }
}