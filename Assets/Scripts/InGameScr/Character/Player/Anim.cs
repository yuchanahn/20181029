using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    #region Singleton
    private static Anim _instance;
    public static Anim Instance
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

    Animator pAnim;

    private void Start()
    {
        pAnim = Player.Instance.transform.parent.GetComponent<Animator>();
    }

    public void DashOn()
    {
        pAnim.SetBool("DASH", true);
    }
    public void DashOff()
    {
        pAnim.SetBool("DASH", false);
    }
}