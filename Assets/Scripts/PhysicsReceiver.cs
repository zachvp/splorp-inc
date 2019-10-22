using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsReceiver : Receiver
{
    [SerializeField]
    public Vector2 velocity;

    private Rigidbody2D body;

    public void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public override void Fire()
    {
        base.Fire();

        body.velocity = velocity;
    }
}
