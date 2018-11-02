using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ySpeed : MonoBehaviour
{
    private void Update()
    {
        if (Player.Instance.ySpeed > Stat.d[eStat.maxYSpeed].Value)
            Player.Instance.ySpeed = Stat.d[eStat.maxYSpeed].Value;


        Player.Instance.ySpeed +=
            Stat.d[eStat.yAcceleration].Value * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Mob") { return; }

        Player.Instance.ySpeed = 0;
    }
}