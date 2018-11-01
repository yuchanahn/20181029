using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    private static Player _instance;
    public static Player Instance
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

    public float xPos
    {
        get { return Stat.d[eStat.xPos].Value; }
        set { Stat.d[eStat.xPos].Value = value; }
    }
    public float ySpeed
    {
        get { return Stat.d[eStat.ySpeed].Value; }
        set { Stat.d[eStat.ySpeed].Value = value; }
    }

    private void Start()
    {
        xPos = 0;
        Stat.d[eStat.xPos].Event += () =>
        {
            if (xPos < -6) xPos = -6;
            if (xPos > 6) xPos = 6;
        };

        Stat.d[eStat.xSpeed].Value = 0;

        ySpeed = 0;
        Stat.d[eStat.ySpeed].Event += () =>
        {
            if (ySpeed > Stat.d[eStat.maxYSpeed].Value)
                ySpeed = Stat.d[eStat.maxYSpeed].Value;
        };
        Stat.d[eStat.maxYSpeed].Value = .5f;
        Stat.d[eStat.yAcceleration].Value = .05f;

        Stat.d[eStat.currentMeter].Value = 0;

        GameOverInit(eStat.temperature, 36.5f);
        GameOverInit(eStat.stamina, 100f);
        GameOverInit(eStat.oxygen, 100f);
        GameOverInit(eStat.health, 3f);
    }

    void GameOverInit(eStat state, float v)
    {
        Stat.d[state].Event += () =>
        {
            if (Stat.d[state].Value < 0)
                Debug.Log("GameOver");
        };
        Stat.d[state].Value = v;
    }
}