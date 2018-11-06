using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum eStat
{
    none,
    currentMeter,
    maxMeter,
    diveTime,
    xPos,
    xSpeed,
    ySpeed,
    maxYSpeed,
    yAcceleration,
    temperature,
    view,
    wetsuit,
    weaponLv,
    stamina,
    staminaRecovery,
    maxStamina,
    oxygen,
    oxygenRecovery,
    maxOxygen,
    health,
    maxHealth,
    money,
    moneyPerMeter,
    SHOP_Wetsuit_INDEX,
    SHOP_weaponLv_INDEX,
    SHOP_Wetsuit_INDEXMAX,
    SHOP_weaponLv_INDEXMAX,

    last,
}

public static class Stat
{
    public static Dictionary<eStat, ReAct<float>> d = new Dictionary<eStat, ReAct<float>>();

    public static void Init()
    {
        for(var i = 0; i < (int)eStat.last; ++i)
        {
            d[(eStat)i] = new ReAct<float>();
        }
        //curMeter.Init(0);
        //maxMeter.Init(0);
        //acceleration.Init(.05f);
        //diveTime.Init(10f);
        //xSpeed.Init(1);
        //ySpeed.Init(0f);
        //maxYSpeed.Init(5f);
        //temperature.Init(36.5f);
        //view.Init(1);
        //wetsuit.Init(1);
        //weaponLv.Init(1);
        //stamina.Init(10f);
        //staminaRecovery.Init(1f);
        //maxStamina.Init(10f);
        //oxygen.Init(10f);
        //oxygenRecovery.Init(1f);
        //maxOxygen.Init(10f);
        //health.Init(3);
        //maxHealth.Init(10);
    }
}
