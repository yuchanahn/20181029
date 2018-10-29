using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pProperty
{
    public ReAct<float> _currentMeter       = new ReAct<float>();
    public ReAct<float> _maxMeter           = new ReAct<float>();
    public ReAct<float> _acceleration       = new ReAct<float>();
    public ReAct<float> _diveTime           = new ReAct<float>();
    public ReAct<float> _xSpeed             = new ReAct<float>();
    public ReAct<float> _ySpeed             = new ReAct<float>();
    public ReAct<float> _temperature        = new ReAct<float>();
    public ReAct<int> _view                 = new ReAct<int>();
    public ReAct<int> _wetsuit              = new ReAct<int>();
    public ReAct<int> _weaponLv             = new ReAct<int>();
    public ReAct<float> _stamina            = new ReAct<float>();
    public ReAct<float> _staminaRecovery    = new ReAct<float>();
    public ReAct<float> _maxStamina         = new ReAct<float>();
    public ReAct<float> _oxygen             = new ReAct<float>();
    public ReAct<float> _oxygenRecovery     = new ReAct<float>();
    public ReAct<float> _maxOxygen          = new ReAct<float>();
    public ReAct<int> _health               = new ReAct<int>();
    public ReAct<int> _maxHealth            = new ReAct<int>();


    void Init()
    {
        _currentMeter.Value = 0;
        _maxMeter.Value = 0;
        _acceleration.Value = 1;
        _diveTime.Value = 10f;
        _xSpeed.Value = 1f;
        _ySpeed.Value = 2f;
        _temperature.Value = 36.5f;
        _view.Value = 1;
        _wetsuit.Value = 1;
        _weaponLv.Value = 1;
        _stamina.Value = 10f;
        _staminaRecovery.Value = 1f;
        _maxStamina.Value = 10f;
        _oxygen.Value = 10f;
        _oxygenRecovery.Value = 1f;
        _maxOxygen.Value = 10f;
        _health.Value = 10;
        _maxHealth.Value = 10;
    }
}
