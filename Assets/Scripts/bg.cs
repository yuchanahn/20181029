using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public BackgroundMgr mgr;

    public GameObject[] bgs;

    private void Start()
    {
        bgs = new GameObject[mgr.bgCount];
    }

    private void Update()
    {
        transform.Translate(0, Stat.d[eStatUI.ySpeed].Value, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "bgCol") { return; }

        for (int i = 0; i < mgr.bgCount; i++)
            bgs[i] = mgr.transform.GetChild(i).gameObject;
        

        for (int i = 0; i < bgs.Length - 1; i++)
        {
            if (bgs[i] != gameObject) { continue; }

            bgs[i + 1].transform.position = new Vector2(0, -5);
            break;
        }

        transform.position = new Vector2(0, 15 - (mgr.bgCount * 20));
    }
}