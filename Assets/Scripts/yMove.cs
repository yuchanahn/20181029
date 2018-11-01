using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yMove : MonoBehaviour {
    
    private void Update()
    {
        Player.Instance.ySpeed += 
            Stat.d[eStatUI.yAcceleration].Value * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Mob") { return; }

        Player.Instance.ySpeed = 0;
    }
}
