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


}
