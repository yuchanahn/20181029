using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetSuit : MonoBehaviour
{
    float curTime;
    const float breathTime = 10;
    private void Start()
    {
        curTime = 0;
    }
    private void Update()
    {
        if (Stat.d[eStat.currentMeter].Value < 100) return;

        curTime += Time.deltaTime;
        if(curTime > breathTime)
        {
            curTime = 0;
            
            Player.Instance.health -= (int)(Stat.d[eStat.currentMeter].Value / 100);
        }
    }
}