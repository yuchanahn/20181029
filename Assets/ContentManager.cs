using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManager : MonoBehaviour
{
    [SerializeField] RectTransform target;
    [SerializeField] float colRange;
    [SerializeField] float acc;
    eStat Index = eStat.SHOP_Wetsuit_INDEX;
    public bool IsDrag { get; set; }
    
    public float startXPos;

    public Vector2 PosTo = new Vector2();

    private void Start()
    {
        PosTo = new Vector2(target.localPosition.x, target.localPosition.y);
        startXPos = target.localPosition.x;
        IsDrag = false;
    }

    public void SetStat(ShopTabManager manager)
    {
        Index = manager.stat;

        PosTo = new Vector2(GetComponent<RectTransform>().sizeDelta.x * -(Stat.d[Index].Value - 1), target.localPosition.y);
        target.localPosition = PosTo;
    }

    public void InRange()
    {
        if ((PosTo.x - target.localPosition.x) > colRange)
        {
            Stat.d[Index].Value++;
        }
        else if ((PosTo.x - target.localPosition.x) < -colRange)
        {
            Stat.d[Index].Value--;
        }

        PosTo = new Vector2(GetComponent<RectTransform>().sizeDelta.x * -(Stat.d[Index].Value - 1), target.localPosition.y);
    }

    private void Update()
    {
        if (!IsDrag)
            target.localPosition = Vector3.Lerp(target.localPosition, PosTo, acc*Time.deltaTime);
    }
}
