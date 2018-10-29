using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float Speed = 0f;

	void Start () {
	}
	
	void Update () {
        transform.Translate(0, -Speed * Time.deltaTime , 0);
	}
}
