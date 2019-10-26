using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsReceiver : Receiver
{
    [SerializeField]
    public Signal activate;

    [SerializeField]
    public Vector2 velocity;

    [SerializeField]
    public Rigidbody2D body;

    public void Awake()
    {
        activate.Emit += Activate;
    }

    public void Activate()
    {
        Debug.LogFormat("{0}: activate", name);

        body.velocity = velocity;
        // todo: force child class to adopt
    }
}
