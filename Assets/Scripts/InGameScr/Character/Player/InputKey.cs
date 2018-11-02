using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    #region Singleton
    private static InputKey _instance;
    public static InputKey Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = this;
    }
    #endregion

    float dashcool = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) { Stat.d[eStat.xSpeed].Value = -5; }
        if (Input.GetKeyDown(KeyCode.D)) { Stat.d[eStat.xSpeed].Value = 5; }

        if (!Player.Instance.IsDash) dashcool += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
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

        if (Player.Instance.IsDash && Input.GetKey(KeyCode.Space))
        {
            Stat.d[eStat.stamina].Value -= 10 * Time.deltaTime;
        }

        if ((Input.GetKeyUp(KeyCode.Space) || Stat.d[eStat.stamina].Value < 0) && Player.Instance.IsDash)
        {
            dashcool = 0;
            Player.Instance.IsDash = false;

            Player.Instance.ySpeed -= Player.Instance.ySpeed / 2;
            Stat.d[eStat.maxYSpeed].Value -= Stat.d[eStat.maxYSpeed].Value / 2;
            Stat.d[eStat.yAcceleration].Value -= Stat.d[eStat.yAcceleration].Value / 2;
        }
    }
}