using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUICtrl : MonoBehaviour
{
    public eStatUI curr;
    public eStatUI max;

    void Awake()
    {
        Stat.Init();
    }

    private void Start()
    {
        if (max != eStatUI.none)
        {
            UpdateStat();
            Stat.d[curr].Event += UpdateStat;
            Stat.d[max].Event += UpdateStat;
        }
        else
        {
            UpdateStat_noneMax();
            Stat.d[curr].Event += UpdateStat_noneMax;
        }
    }



    void UpdateStat()
    {
        transform.GetChild(3).GetComponent<Text>().text = Stat.d[curr].Value + "/" + Stat.d[max].Value;
    }
    void UpdateStat_noneMax()
    {
        transform.GetChild(3).GetComponent<Text>().text = ""+Stat.d[curr].Value;
    }
}
