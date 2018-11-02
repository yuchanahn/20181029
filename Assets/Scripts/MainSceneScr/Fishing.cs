using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fishing : MonoBehaviour
{
    float dt =0;
    [SerializeField] float _delayTime = 1;
    [SerializeField] Text delayTime;
    [SerializeField] float percent;

    bool bFishing;

    public void StartFishing()
    {
        if (bFishing) {
            GetFishing(Random.Range(1, 100));
        }
        else
        {
            delayTime.color = Color.red;
            DelayAct.DAct(()=> { delayTime.color = Color.black; },0.5f);
        }
    }


    void GetFishing(float rand)
    {
        bFishing = false;
        dt = _delayTime;
        if (percent >= rand)
        {
            Debug.Log("성공! 300원 추가.");
            Stat.d[eStat.money].Value += 300;
        }
        else
        {
            Debug.Log("실패!");
        }
    }

    private void Update()
    {
        dt -= Time.deltaTime;
        if (dt <= 0)
        {
            dt = 0;
            bFishing = true;
            delayTime.text = ((int)dt).ToString();
            return;
        }
        delayTime.text = ((int)dt + 1).ToString();
    }
}
