﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "player") { return; }
        Stat.d[eStatUI.health].Value -= 1;

        Destroy(gameObject);
    }
}