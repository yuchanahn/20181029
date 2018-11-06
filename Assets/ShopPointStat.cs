using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPointStat : MonoBehaviour
{
    public static ShopPointStat instance;

    [SerializeField] Text mname;
    [SerializeField] Text info;
    [SerializeField] Text statName;
    [SerializeField] Text statValue;

    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public static void Set(GameObject item)
    {
        Item mitem = item.GetComponent<Shop>().item.Value;
        instance.mname.text = mitem.name;
        instance.info.text = mitem.info;
        instance.statName.text = mitem.stat.ToString();
        instance.statValue.text = mitem.UpStat.ToString();
    }
}
