using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    int prevMeter = 10;
    // Update is called once per frame
    void Update()
    {
        Stat.d[eStat.currentMeter].Value += Player.Instance.ySpeed / 10 * Time.deltaTime;

        // 10 Meter 당 10원
        
        if ((int)Stat.d[eStat.currentMeter].Value == prevMeter)
        {
            prevMeter += 10;

            Stat.d[eStat.money].Value += 10;
            Debug.Log("" + Stat.d[eStat.money].Value);
        }
    }
}