using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReAct<T>
{
    T value;
    public T Value
    {
        get
        {
            return value;
        }
        set
        {
            PrevEvent();
            this.value = value;
            Event();
        }
    }

    public Action Event;
    public Action PrevEvent;
    bool islock = false;
    public void Init(T val)
    {
        if (islock) return;
        
        islock = true;
        value = val;
        Event = () => { };
        PrevEvent = () => { };
    }
    
}
