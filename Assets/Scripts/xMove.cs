using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xMove : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) { Stat.d[eStat.xSpeed].Value = -5; }
        if(Input.GetKeyDown(KeyCode.D)) { Stat.d[eStat.xSpeed].Value =  5; }

        Player.Instance.xPos += Stat.d[eStat.xSpeed].Value * Time.deltaTime;

        Player.Instance.transform.position 
            = new Vector2(Player.Instance.xPos, Player.Instance.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "pCol") { return; }

        Stat.d[eStat.xSpeed].Value = 0;
    }
}
