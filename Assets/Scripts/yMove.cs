using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yMove : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Mob") { return; }

        Stat.d[eStatUI.ySpeed].Value = 0;
    }
}
