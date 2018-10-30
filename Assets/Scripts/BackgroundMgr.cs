using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMgr : MonoBehaviour
{
    public Player player;
    
    public GameObject bg;
    
    void Update()
    {
        bg.transform.Translate(0, player.property.ySpeed.Value, 0);
    }

}
