using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMgr : MonoBehaviour
{
    public int bgCount = 3;
    
    public float speed
    {
        get { return Stat.d[eStatUI.ySpeed].Value; }
        set { Stat.d[eStatUI.ySpeed].Value = value; }
    }
    public float maxSpeed
    {
        get { return Stat.d[eStatUI.maxYSpeed].Value; }
        set { Stat.d[eStatUI.maxYSpeed].Value = value; }
    }
    public float speedAccel
    {
        get { return Stat.d[eStatUI.acceleration].Value; }
        set { Stat.d[eStatUI.acceleration].Value = value; }
    }

    private void Start()
    {
        speedAccel = .05f;
        speed = 0;
        maxSpeed = .5f;

        Stat.d[eStatUI.ySpeed].Event = () =>
        {
            if (speed > maxSpeed)
                speed = maxSpeed;
        };
    }

    void Update()
    {
        speed += speedAccel * Time.deltaTime;
    }

}
