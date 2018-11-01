using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, Player.Instance.ySpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "bgCol") { return; }

        BackgroundMgr.Instance.CollideUpdate(gameObject);

        float y = 15 - (BackgroundMgr.Instance.bgCount * 20);
        transform.position = new Vector2(0, y);
    }
}