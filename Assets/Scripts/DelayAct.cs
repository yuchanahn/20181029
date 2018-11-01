using System.Collections;
using UnityEngine;
using System;



public class DelayAct : MonoBehaviour
{
    static DelayAct instance;
    private void Awake()
    {
        instance = this;
    }

    public static void DAct(Action act, float t)
    {
        instance.Act(act,t);
    }

    public void Act(Action act, float t)
    {
        StartCoroutine(NetUpdate(act, t));
    }

    public IEnumerator NetUpdate(Action action, float t)
    {
        yield return new WaitForSeconds(t);
        action();
    }
}
