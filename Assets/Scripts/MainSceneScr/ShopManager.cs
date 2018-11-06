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



    void Start()
    {
        Stat.d[eStat.money].Value = 1000;
        mtabMsanagerObj.GetComponent<Image>().color = Color.grey;
        SetRect(wetsuits, wetsuitTab.transform);
        SetRect(weapons, weaponTab.transform);
    }

    public void On(GameObject shopObj, GameObject tabManagerObj)
    {
        mshopTab.SetActive(false);
        shopObj.SetActive(true);
        mshopTab = shopObj;
        mtabMsanagerObj.GetComponent<Image>().color = Color.white;
        tabManagerObj.GetComponent<Image>().color = Color.grey;
        mtabMsanagerObj = tabManagerObj;
    }


    void SetRect(Item[] item, Transform itemObjPr)
    {
        float mXSize = itemObjPr.GetComponent<RectTransform>().sizeDelta.x;

        content.sizeDelta = new Vector2(item.Length * mXSize, 415);

        for (int i = 0; i < item.Length; i++)
        {
            MakeItemObj(itemObjPr, i, mXSize, item[i]);
        }
    }

    void MakeItemObj(Transform itemObjPr, int n, float xSize, Item item)
    {
        var obj = Instantiate(itemObj, itemObjPr);

        obj.GetComponent<Shop>().init();
        obj.GetComponent<Shop>().item.Value = item;
        obj.GetComponent<Shop>().startPos = new Vector2(xSize * n, 0);
    }
}