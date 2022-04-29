using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EntityBase
{
    Vector3 dir;
    private float speed = 10f;

    protected override void Dead()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        base.Dead();
    }

    private void Update()
    {
        Vector3 dir = Vector3.down;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
