using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTabManager : MonoBehaviour
{
    [SerializeField] GameObject[] mTabObj = new GameObject[2];
    public void On(ShopManager shopManager)
    {
        shopManager.On(mTabObj[1], mTabObj[0]);
    }
}