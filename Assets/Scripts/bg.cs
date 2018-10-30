using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public BackgroundMgr bgmgr;

    GameObject[] b = new GameObject[2];

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "background")
        {
            for (int i = 0; i < 2; i++)
                b[i] = transform.GetChild(i).gameObject;

            b[0].transform.SetParent(transform.parent);
            b[1].transform.SetParent(b[0].transform);
            transform.SetParent(b[0].transform);

            Debug.Log("1 : " + transform.position.y + "2 : " + b[0].transform.position.y + "3 : " + b[1].transform.position.y);
            bgmgr.bg = b[0];

            b[0].transform.position = new Vector2(0, -5);
            b[1].transform.position = new Vector2(0, -25);
            transform.position = new Vector2(0, -45);
        }
    }
}