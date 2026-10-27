using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnemyScale : EnemyBase
{
    [Header ("Enemy Scale")]
    public float scale = 1.5f;
    public float duration = 1f;

    [Space()]
    private bool _attacking = false;

    public override void Attack()
    {
        base.Attack();

        if(!_attacking)
        {
            _attacking = true;
            transform.localScale *= scale;
            Invoke("ResetScale", duration);

        }

    }

    public void ResetScale()
    {
        transform.localScale = Vector3.one;
        _attacking = false;
    }

       
}
