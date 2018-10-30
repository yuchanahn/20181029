using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pProperty
{
    public ReAct<float> currentMeter       = new ReAct<float>();
    public ReAct<float> maxMeter           = new ReAct<float>();
    public ReAct<float> acceleration       = new ReAct<float>();
    public ReAct<float> maxAcceleration    = new ReAct<float>();
    public ReAct<float> diveTime           = new ReAct<float>();
    public ReAct<int>   xSpeed               = new ReAct<int>();
    public ReAct<float> ySpeed             = new ReAct<float>();
    public ReAct<float> maxYSpeed          = new ReAct<float>();
    public ReAct<float> temperature        = new ReAct<float>();
    public ReAct<int>   view                 = new ReAct<int>();
    public ReAct<int>   wetsuit              = new ReAct<int>();
    public ReAct<int>   weaponLv             = new ReAct<int>();
    public ReAct<float> stamina            = new ReAct<float>();
    public ReAct<float> staminaRecovery    = new ReAct<float>();
    public ReAct<float> maxStamina         = new ReAct<float>();
    public ReAct<float> oxygen             = new ReAct<float>();
    public ReAct<float> oxygenRecovery     = new ReAct<float>();
    public ReAct<float> maxOxygen          = new ReAct<float>();
    public ReAct<int>   health               = new ReAct<int>();
    public ReAct<int>   maxHealth            = new ReAct<int>();

    public void Init()
    {
        currentMeter.       Init(0);
        maxMeter.           Init(0);
        acceleration.       Init(.05f);
        maxAcceleration.    Init(.5f);
        diveTime.           Init(10f);
        xSpeed.             Init(1);
        ySpeed.             Init(0f);
        maxYSpeed.          Init(5f);
        temperature.        Init(36.5f);
        view.               Init(1);
        wetsuit.            Init(1);
        weaponLv.           Init(1);
        stamina.            Init(10f);
        staminaRecovery.    Init(1f);
        maxStamina.         Init(10f);
        oxygen.             Init(10f);
        oxygenRecovery.     Init(1f);
        maxOxygen.          Init(10f);
        health.             Init(3);
        maxHealth.          Init(10);
    }
}
