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

        if (collisionData.collision != null && collisionData.collision.contactCount > 0)
        {
            var points = new ContactPoint2D[collisionData.collision.contactCount];
            
            // store collision contacts in array
            collisionData.collision.collider.GetContacts(points);

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

        Events.Raise(actorData.OnChange);
    }

    public void LateUpdate()
    {
        actorData.Clear();
    }
}
