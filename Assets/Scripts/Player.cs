using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eUINum
{
    LABAL,
    BACK,
    BAR,
    TEXT,
}

public class Player : MonoBehaviour {

    public pProperty property;

    private void Awake()
    {
        property = new pProperty();

        property.Init();
    }

    void Update () {
		
	}
}
