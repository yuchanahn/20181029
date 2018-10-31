using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMgr : MonoBehaviour
{
    public GameObject bg;
    
    void Update()
    {
        bg.transform.Translate(0, Stat.d[eStatUI.ySpeed].Value, 0);
    }

}
