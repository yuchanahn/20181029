using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum eStatUI
{
    none,
    currentMeter,
    maxMeter,
    diveTime,
    xSpeed,
    xPos,
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


    last,
}

public static class Stat
{
    public static Dictionary<eStatUI, ReAct<float>> d = new Dictionary<eStatUI, ReAct<float>>();

    public static void Init()
    {
        for(var i = 0; i < (int)eStatUI.last; ++i)
        {
            d[(eStatUI)i] = new ReAct<float>();
            d[(eStatUI)i].Init(0);
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
