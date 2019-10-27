using UnityEngine;

public class PlatformActorWriter : MonoBehaviour
{
    [SerializeField]
    public PlatformActorData actorData;

    [SerializeField]
    public CollisionData collisionData;

    public void Update()
    {
        actorData.up = transform.up;

        foreach(Collision2D collision in collisionData.collisions)
        {
            if (collision.contactCount > 0)
            {
                var points = new ContactPoint2D[collision.contactCount];
                
                // store collision contacts in array
                collision.collider.GetContacts(points);

                foreach (ContactPoint2D point in points)
                {
                    var dot = Vector2.Dot(point.normal, actorData.up);

                    // check that this contact is in opposite direction as other contact
                    if (dot < -0.95f)
                    {
                        actorData.state = PlatformActorState.GROUNDED;
                        break;
                    }
                }
            }
        }

        Events.Raise(actorData.OnChange);
    }

    public void LateUpdate()
    {
        actorData.Clear();
    }
}
