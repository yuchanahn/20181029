using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xPos : MonoBehaviour
{
    private void Update()
    {
        if (Player.Instance.xPos < -6) Player.Instance.xPos = -6;
        if (Player.Instance.xPos > 6) Player.Instance.xPos = 6;

        Player.Instance.xPos += Stat.d[eStat.xSpeed].Value * Time.deltaTime;

        Player.Instance.transform.position 
            = new Vector2(Player.Instance.xPos, Player.Instance.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "pCol") { return; }

        Debug.Log("a");
        Stat.d[eStat.xSpeed].Value = 0;
    }
}
