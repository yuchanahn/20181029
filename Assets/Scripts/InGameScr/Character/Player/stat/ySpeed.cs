using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ySpeed : MonoBehaviour
{
    private void Update()
    {
        // Speed
        SpeedUpdate();

        // Dash
        DashUpdate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Mob") { return; }

        Player.Instance.ySpeed = 0;
    }

    private void SpeedUpdate()
    {
        if (Player.Instance.ySpeed > Stat.d[eStat.maxYSpeed].Value)
            Player.Instance.ySpeed = Stat.d[eStat.maxYSpeed].Value;


        Player.Instance.ySpeed +=
            Stat.d[eStat.yAcceleration].Value * Time.deltaTime;
    }

    private void DashUpdate()
    {
        if (!Player.Instance.IsDash) dashcool += Time.deltaTime;
    }

    float dashcool = 0;
    public void DashOn()
    {
        if (dashcool > 1)
        {
            if (Stat.d[eStat.stamina].Value > 10)
            {
                dashcool = 0;
                Player.Instance.IsDash = true;

                Player.Instance.ySpeed += Player.Instance.ySpeed;
                Stat.d[eStat.maxYSpeed].Value += Stat.d[eStat.maxYSpeed].Value;
                Stat.d[eStat.yAcceleration].Value += Stat.d[eStat.yAcceleration].Value;
            }
        }
    }

    public void Dash()
    {
        if (Player.Instance.IsDash)
            Stat.d[eStat.stamina].Value -= 10 * Time.deltaTime;
    }

    public void DashOff()
    {
        if (Player.Instance.IsDash)
        {
            dashcool = 0;
            Player.Instance.IsDash = false;

            Player.Instance.ySpeed -= Player.Instance.ySpeed / 2;
            Stat.d[eStat.maxYSpeed].Value -= Stat.d[eStat.maxYSpeed].Value / 2;
            Stat.d[eStat.yAcceleration].Value -= Stat.d[eStat.yAcceleration].Value / 2;
        }
    }
}