using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB : MonoBehaviour {

    [SerializeField] eStat[] data;

    public void Save()
    {
        foreach (var i in data)
        {
            PlayerPrefs.SetFloat(i.ToString(),Stat.d[i].Value);
        }
    }

    public void load()
    {
        foreach (var i in data)
        {
            PlayerPrefs.GetFloat(i.ToString(), Stat.d[i].Value);
        }
    }

}
