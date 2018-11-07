using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Shop : MonoBehaviour {
    public Vector2 startPos;

    public int mslotNumber;

    [SerializeField] Text mname;
    [SerializeField] Text price;
    [SerializeField] Image image;
    [SerializeField] GameObject buttonOfBuy;

    [SerializeField] GameObject[] EquipText;

    [SerializeField] GameObject soldImage;
    public bool Equip = false;

    public ReAct<Item> item = new ReAct<Item>();
    


    public void init()
    {
        item.Event += () =>
        {
            mname.text = item.Value.name;
            price.text = item.Value.price.ToString();
            image.sprite = item.Value.Image;
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

    public void Sold()
    {
        buttonOfBuy.SetActive(false);
        soldImage.SetActive(true);
    }

    public void Equipment(int SlotNum, bool b)
    {
        if(mslotNumber == SlotNum)
        {
            Equip = b;
            Equipment();
        }
    }

    public void Equipment()
    {
        Equip = !Equip;
        
        EquipText[0].gameObject.SetActive(Equip);
        EquipText[1].gameObject.SetActive(!Equip);

        if (Equip)
        {
            Stat.d[item.Value.stat].Value += item.Value.UpStat;
            GetComponentInParent<ShopManager>().SetItemEquip(item.Value.stat, this);
        }
        else
        {
            Stat.d[item.Value.stat].Value -= item.Value.UpStat;
        }
    }

    public void Buy()
    {
        if (Stat.d[eStat.money].Value >= item.Value.price)
        {
            Stat.d[eStat.money].Value -= item.Value.price;
            DB.IItems[item.Value.stat].Add(mslotNumber);
            Sold();
        }
        else
        {
            price.color = Color.red;
            DelayAct.DAct(()=> { price.color = Color.black; },0.5f);
        }
    }
}
