using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InGameUIMgr : MonoBehaviour
{
    GameObject UImgr;
    public Text[] UIText;

    void Start()
    {
        UIText = GetComponentsInChildren<Text>();
    }

    private void Init()
    {
        Stat.d[eStatUI.oxygen].Event += ()=>
        {
            UIText[0].text = ""+1;
        };
    }

}