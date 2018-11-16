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

    public Player player;
    public xSpeed xSpeedInput;
    public ySpeed ySpeedInput;
    public WeaponLv WeapInput;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        xSpeedInput = player.stMgr.GetComponent<xSpeed>();
        ySpeedInput = player.stMgr.GetComponent<ySpeed>();
        WeapInput = player.stMgr.GetComponent<WeaponLv>();
    }

    private void Update()
    {
        //Move
        if (Input.GetKeyDown(KeyCode.A)) { xSpeedInput.Left(); }
        if (Input.GetKeyDown(KeyCode.D)) { xSpeedInput.Right(); }

        // Dash
        if (Input.GetKeyDown(KeyCode.Space)) { ySpeedInput.DashOn(); }
        if (Input.GetKey(KeyCode.Space)) { ySpeedInput.Dash(); }
        if (Input.GetKeyUp(KeyCode.Space) || Stat.d[eStat.stamina].Value < 0) { ySpeedInput.DashOff(); }

        // Click
        if (Input.GetMouseButtonDown(0)) { WeapInput.MobCollide(); }
    }
}