using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Shop : MonoBehaviour {
    public Vector2 startPos;
    [SerializeField] Text mname;
    [SerializeField] Text price;

    public ReAct<Item> item = new ReAct<Item>();



    public void init()
    {
        item.Event += () =>
        {
            mname.text = item.Value.name;
            price.text = item.Value.price.ToString();
        };
    }
    private void Start()
    {
        GetComponent<RectTransform>().localPosition = startPos;
    }

    public void ShowPoint(bool b)
    {
        ShopPointStat.instance.gameObject.SetActive(b);
        ShopPointStat.Set(gameObject);
    }
}
