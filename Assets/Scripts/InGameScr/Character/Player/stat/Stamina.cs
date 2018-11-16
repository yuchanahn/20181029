using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    private void Start()
    {
        Stat.d[eStat.stamina].Event += () =>
        {
            // Dash
            if(Player.Instance.IsDash)
            {
                Anim.Instance.DashOn();
            }
            else
            {
                Anim.Instance.DashOff();
            }
        };
    }
    
    // Update is called once per frame
    private void Update()
    {
        if(!Player.Instance.IsDash)
        {
            Stat.d[eStat.stamina].Value += Stat.d[eStat.staminaRecovery].Value * Time.deltaTime;
        }
    }
}