using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUICtrl : MonoBehaviour
{
    public eStatUI curr;
    public eStatUI max;

    [SerializeField] GameObject mGage;

    void Awake()
    {
        Stat.Init();
        Stat.d[eStatUI.oxygen].Value = 1000;
        Stat.d[eStatUI.maxOxygen].Value = 1000;
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

    private void Update()
    {
    }

    void UpdateStat()
    {
        transform.GetChild(3).GetComponent<Text>().text = (int)Stat.d[curr].Value + "/" + (int)Stat.d[max].Value;
        mGage.transform.localScale = new Vector3(Stat.d[curr].Value / Stat.d[max].Value, 1,1);
    }
    void UpdateStat_noneMax()
    {
        transform.GetChild(3).GetComponent<Text>().text = ""+Stat.d[curr].Value;
    }
}
