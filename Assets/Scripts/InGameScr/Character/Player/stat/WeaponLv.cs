using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLv : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void MobCollide()
    {
        Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Ray2D ray = new Ray2D(wp, Vector2.zero);
        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);

        foreach (var hit in hits)
        {
            if (hit.collider.CompareTag("Mob"))
                Destroy(hit.collider.gameObject);
        }
    }
}