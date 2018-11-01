using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InGameUIMgr : MonoBehaviour
{
    void Start()
    {
        Stat.d[eStatUI.maxHealth].Value = 10;
        Stat.d[eStatUI.maxOxygen].Value = 150;
    }
}