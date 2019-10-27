using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CollisionWriter : MonoBehaviour
{
    [SerializeField]
    public CollisionData data;

    public void LateUpdate()
    {
        data.Clear();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        data.collision = collision;

        Events.Raise(data.OnChange);
    }
}
