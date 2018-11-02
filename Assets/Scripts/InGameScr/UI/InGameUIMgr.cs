using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InGameUIMgr : MonoBehaviour
{
    void Start()
    {
        Stat.d[eStat.maxHealth].Value = 10;
        Stat.d[eStat.maxOxygen].Value = 150;
    }
}