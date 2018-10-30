using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Player player;

    int Dir;

    public int curDir
    {
        get 
        {
            return Dir;
        }
        set
        {
            if (value * value != 144)
            {
                Dir = value;
            }
        }
    }


    private void Start()
    {
        player = GetComponent<Player>();
       
        // Move Y
        player.property.ySpeed.Event = () =>
        {
            if (player.property.maxYSpeed.Value < player.property.ySpeed.Value)
                player.property.ySpeed.Value = player.property.maxYSpeed.Value;
        };

        player.property.acceleration.Event = () =>
        {
            if (player.property.maxAcceleration.Value < player.property.acceleration.Value)
                player.property.acceleration.Value = player.property.maxAcceleration.Value;
        };

        // Move X
        curDir = 0;
    }

    void Update()
    {
        moveXUpdate();
        moveYUpdate();
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    int prevDir = 0;
    int speed = 0;

    void moveXUpdate()
    {
        prevDir = curDir;
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed = -6;
            curDir -= 6;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            speed = 6;
            curDir += 6;
        }

        curDir *= player.property.xSpeed.Value;
    }

    void moveYUpdate()
    {
        player.property.ySpeed.Value += player.property.acceleration.Value * Time.deltaTime;
        player.property.acceleration.Value += player.property.acceleration.Value / 2 * Time.deltaTime;
    }

}