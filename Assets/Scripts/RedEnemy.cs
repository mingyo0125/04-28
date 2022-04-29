using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : EntityBase
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

    private void Start()
    {
        {
        int randValue = UnityEngine.Random.Range(0, 1);
        if (randValue < 2)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position-transform.position;
            dir.Normalize();
        }
    }
    }

    private void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
