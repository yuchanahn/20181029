using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReAct<T>
{
    T _value;
    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            PrevEvent();
            _value = value;
            Event();
        }
    }

    public Action Event = () => { };
    public Action PrevEvent = () => { };

    public ReAct(T value)
    {
        _value = value;
    }
    public ReAct()
    {
    }
}
