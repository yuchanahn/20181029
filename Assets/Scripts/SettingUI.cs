using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUI : MonoBehaviour
{
    public int n = 0;
    public GameObject obj;


    private void Start()
    {
        obj = GameObject.Find("Oxygen").gameObject;

        Vector2 v2 = new Vector2(obj.GetComponent<RectTransform>().position.x, obj.GetComponent<RectTransform>().position.y);

        for (int i = 1; i < n; i++)
        {
            Vector2 v2_2 = new Vector2(v2.x, v2.y - i * 30);
            GameObject a = Instantiate(obj,v2_2 ,Quaternion.identity);
            a.transform.SetParent(this.transform);
            a.GetComponent<RectTransform>().sizeDelta = new Vector2(obj.GetComponent<RectTransform>().sizeDelta.x, obj.GetComponent<RectTransform>().sizeDelta.y);
        }
    }
}
