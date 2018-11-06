using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTabManager : MonoBehaviour
{
    public eStat stat;
    public eStat statMax;
    [SerializeField] GameObject[] mTabObj = new GameObject[2];
    public void On(ShopManager shopManager)
    {
        shopManager.On(mTabObj[1], mTabObj[0]);
    }
    private void Awake()
    {
        Stat.d[stat].Event += () =>
        {
            if(Stat.d[stat].Value < 1)
            {
                Stat.d[stat].Value = 1;
            }
            else if (Stat.d[statMax].Value < Stat.d[stat].Value)
            {
                Stat.d[stat].Value = Stat.d[statMax].Value;
            }
        };
    }
}