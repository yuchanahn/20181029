﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") { return; }
        Stat.d[eStat.health].Value -= 1;

        Destroy(gameObject);
    }
}