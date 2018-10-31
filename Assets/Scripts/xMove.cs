using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xMove : MonoBehaviour
{
    public GameObject player;

    public float speed;
    private float X
    {
        get { return Stat.d[eStatUI.xSpeed].Value; }
        set
        {
            if (-6 <= value && value <= 6)
                Stat.d[eStatUI.xSpeed].Value = value;
        }
    }

    public float direction;
    public bool isStop = false;
    private void Start()
    {
        direction = 0;
        speed = 0;
        X = 0;
        isStop = false;

        Stat.d[eStatUI.xSpeed].Event = () =>
        {
            if(isStop)
                speed = 0;
        };
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            isStop = false;
            speed = 5;
            direction = -1;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            isStop = false;
            speed = 5;
            direction = 1;
        }

        X += speed * Time.deltaTime * direction;

        player.transform.position = new Vector2(X, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "pCol") { return; }

        isStop = true;
    }
}
