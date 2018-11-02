using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Shop : MonoBehaviour {

    [SerializeField] eStat item;
    [SerializeField] float AddRate;
    [SerializeField] float PriceAddRate;

    [SerializeField] Text lv;
    [SerializeField] Text value;
    [SerializeField] Text pri;


    public int _Price;
    public float _value = 1;

    ReAct<int> LV = new ReAct<int>(1);


    private void Start()
    {
        UpdateText();
        LV.Event += () => 
        {
            _Price += (int)(_Price * PriceAddRate);
            int addValue = (int)(_value * AddRate);

            _value += addValue;
            Stat.d[item].Value += addValue;
            UpdateText();
        };
    }

    void UpdateText()
    {
        value.text = _value.ToString();
        lv.text = LV.Value.ToString();
        pri.text = _Price.ToString();
    }

    public void GetItem()
    {
        if(_Price <= Stat.d[eStat.money].Value)
        {
            Stat.d[eStat.money].Value -= _Price;
            ++LV.Value;
        }
        else
        {
            pri.color = Color.red;
            DelayAct.DAct(()=> { pri.color = Color.black; },0.5f);
        }
    }
}
