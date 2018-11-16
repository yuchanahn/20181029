using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xSpeed : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void Left()
    {
        Stat.d[eStat.xSpeed].Value = -5;
    }

    public void Right()
    {
        Stat.d[eStat.xSpeed].Value = 5;
    }
}