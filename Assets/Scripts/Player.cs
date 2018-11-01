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
        get { return Stat.d[eStatUI.xPos].Value; }
        set { Stat.d[eStatUI.xPos].Value = value; }
    }
    public float ySpeed
    {
        get { return Stat.d[eStatUI.ySpeed].Value; }
        set { Stat.d[eStatUI.ySpeed].Value = value; }
    }

    private void Start()
    {
        xPos = 0;
        Stat.d[eStatUI.xPos].Event += () =>
        {
            if (xPos < -6) xPos = -6;
            if (xPos > 6) xPos = 6;
        };

        Stat.d[eStatUI.xSpeed].Value = 0;

        ySpeed = 0;
        Stat.d[eStatUI.ySpeed].Event += () =>
        {
            if (ySpeed > Stat.d[eStatUI.maxYSpeed].Value)
                ySpeed = Stat.d[eStatUI.maxYSpeed].Value;
        };
        Stat.d[eStatUI.maxYSpeed].Value = .5f;
        Stat.d[eStatUI.yAcceleration].Value = .05f;

        Stat.d[eStatUI.currentMeter].Value = 0;

        GameOverInit(eStatUI.temperature, 36.5f);
        GameOverInit(eStatUI.stamina, 100f);
        GameOverInit(eStatUI.oxygen, 100f);
        GameOverInit(eStatUI.health, 3f);
    }

    void GameOverInit(eStatUI state, float v)
    {
        Stat.d[state].Event += () =>
        {
            if (Stat.d[state].Value < 0)
                Debug.Log("GameOver");
        };
        Stat.d[state].Value = v;
    }
}