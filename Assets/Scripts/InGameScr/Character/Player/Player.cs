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
        stMgr = transform.GetChild(0).gameObject;
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
    public float health
    {
        get { return Stat.d[eStat.health].Value; }
        set { Stat.d[eStat.health].Value = value; }
    }

    public GameObject stMgr;

    public bool IsDash = false;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        xPos = 0;
        Stat.d[eStat.xSpeed].Value = 0;

        ySpeed = 0;
        Stat.d[eStat.maxYSpeed].Value = 5f;
        Stat.d[eStat.yAcceleration].Value = .5f;

        Stat.d[eStat.currentMeter].Value = 0;

        Stat.d[eStat.stamina].Value = Stat.d[eStat.maxStamina].Value;
        
        GameOverInit(eStat.temperature, 36.5f);
        GameOverInit(eStat.oxygen, 100f);
        GameOverInit(eStat.health, 10f);

    }
    
    private void GameOverInit(eStat state, float v)
    {
        Stat.d[state].Event += () =>
        {
            if (Stat.d[state].Value < 0)
            {
                Stat.d[state].Value = 0;
                Debug.Log("GameOver");
            }
        };
        Stat.d[state].Value = v;
    }
}