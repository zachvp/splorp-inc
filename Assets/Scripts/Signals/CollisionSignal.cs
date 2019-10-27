using UnityEngine;

public class CollisionSignal : Signal
{
    [SerializeField]
    public CollisionData data;

    public LayerMask layer;

    public void Awake()
    {
        data.OnChange += HandleOnChange;
    }

    public void HandleOnChange()
    {
        foreach (Collision2D c in data.collisions)
        {
            if (c.otherCollider.IsTouchingLayers(layer))
            {
                Debug.LogFormat("emit collision signal");
                Events.Raise(Emit);
            }
        }
    }
}
