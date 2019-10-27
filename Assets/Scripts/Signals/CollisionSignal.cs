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
        if (data.collision != null && data.collision.otherCollider.IsTouchingLayers(layer))
        {
            Debug.LogFormat("emit collision signal");
            Events.Raise(Emit);
        }
    }
}
