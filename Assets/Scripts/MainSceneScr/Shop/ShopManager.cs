using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class Item
{
    public string name;
    public string info;
    public Sprite Image;
    public eStat stat;
    public float UpStat;
    public int price;
}

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject itemObj;

    [SerializeField] GameObject mtabMsanagerObj;
    [SerializeField] GameObject mshopTab;

    [SerializeField] GameObject wetsuitTab;
    [SerializeField] GameObject weaponTab;
    [SerializeField] RectTransform content;

    public Item[] wetsuits;
    public Item[] weapons;

    Dictionary<GameObject, Vector2> conSize = new Dictionary<GameObject, Vector2>();
    Dictionary<eStat, List<Shop>> ALLItemSlot = new Dictionary<eStat, List<Shop>>();
    void Start()
    {
        SetRect(wetsuits, wetsuitTab.transform);
        SetRect(weapons, weaponTab.transform);
        Stat.d[eStat.SHOP_Wetsuit_INDEXMAX].Value = wetsuits.Length;
        Stat.d[eStat.SHOP_weaponLv_INDEXMAX].Value = weapons.Length;

        On(wetsuitTab, mtabMsanagerObj);
    }


    

    public void On(GameObject shopObj, GameObject tabManagerObj)
    {
        mshopTab.SetActive(false);
        shopObj.SetActive(true);
        mshopTab = shopObj;
        mtabMsanagerObj.GetComponent<Image>().color = Color.white;
        tabManagerObj.GetComponent<Image>().color = Color.grey;
        mtabMsanagerObj = tabManagerObj;
        content.sizeDelta = conSize[shopObj];
    }

 
    public void SetItemEquip(eStat mstat, Shop shop)
    {
        foreach(var i in ALLItemSlot[mstat])
        {
            if ((DB.equipItems[mstat] != -1) && (shop.mslotNumber != DB.equipItems[mstat]))
            {
                i.Equipment(DB.equipItems[mstat], false);
            }
        }
        DB.equipItems[mstat] = shop.mslotNumber;
    }


    void SetRect(Item[] item, Transform itemObjPr)
    {
        float mXSize = itemObjPr.GetComponent<RectTransform>().sizeDelta.x;
        conSize[itemObjPr.gameObject] = new Vector2(item.Length * mXSize, content.sizeDelta.y);

        ALLItemSlot[item[0].stat] = new List<Shop>();

        for (int i = 0; i < item.Length; i++)
        {
            ALLItemSlot[item[0].stat].Add(MakeItemObj(itemObjPr, i, mXSize, item[i]));
        }
    }



    Shop MakeItemObj(Transform itemObjPr, int n, float xSize, Item item)
    {
        Shop _shop = Instantiate(itemObj, itemObjPr).GetComponent<Shop>();
        _shop.init();
        _shop.item.Value = item;
        _shop.startPos = new Vector2(xSize * n, 0);
        _shop.mslotNumber = n;
        return _shop;
    }
}