using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xMove : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) { Stat.d[eStatUI.xSpeed].Value = -5; }
        if(Input.GetKeyDown(KeyCode.D)) { Stat.d[eStatUI.xSpeed].Value =  5; }

        Player.Instance.xPos += Stat.d[eStatUI.xSpeed].Value * Time.deltaTime;

        Player.Instance.transform.position 
            = new Vector2(Player.Instance.xPos, Player.Instance.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "pCol") { return; }

        Stat.d[eStatUI.xSpeed].Value = 0;
    }
}
