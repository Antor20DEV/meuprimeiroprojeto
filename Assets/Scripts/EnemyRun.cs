using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyRun : EnemyBase
{

    [Header("Enemy Run")]
    public UnityEvent EmenyRun;
    public float speed;

    private void Awake()
    {
        Attack();
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Attack run");
    }
}
