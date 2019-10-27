using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CollisionWriter : MonoBehaviour
{
    [SerializeField]
    public CollisionData data;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        data.collisions.Add(collision);

        Events.Raise(data.OnChange);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        data.collisions.Remove(collision);

        Events.Raise(data.OnChange);
    }
}
