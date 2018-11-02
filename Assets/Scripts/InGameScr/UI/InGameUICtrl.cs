using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUICtrl : MonoBehaviour
{
    public eStat curr;
    public eStat max;

    [SerializeField] GameObject mGage;

    void Awake()
    {
        //Stat.Init();
    }

    private void Start()
    {
        if (max != eStat.none)
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
        if ((Stat.d[curr].Value != 0) && (Stat.d[max].Value != 0))
        {
            mGage.transform.localScale = new Vector3(Stat.d[curr].Value / Stat.d[max].Value, 1, 1);
        }
    }
    void UpdateStat_noneMax()
    {
        transform.GetChild(3).GetComponent<Text>().text = ""+Stat.d[curr].Value;
    }
}
