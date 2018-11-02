using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMgr : MonoBehaviour
{
    #region Singleton
    private static BackgroundMgr _instance;
    public static BackgroundMgr Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = this;
    }
    #endregion

    public int bgCount = 3;

    public GameObject[] bgs = new GameObject[1];
    private void Start()
    {
        bgs = new GameObject[bgCount];
    }

    public void CollideUpdate(GameObject colBG)
    {
        for (int i = 0; i < bgCount; i++)
            bgs[i] = transform.GetChild(i).gameObject;

        for (int i = 1; i < bgs.Length; i++)
        {
            if (bgs[i - 1] == colBG)
                bgs[i].transform.position = new Vector2(0, -5);
        }

    }
}
