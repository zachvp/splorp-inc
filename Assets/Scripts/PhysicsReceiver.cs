using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsReceiver : Receiver
{
    [SerializeField]
    public Signal activate;

    [SerializeField]
    public Signal deactivate;

    public void Awake()
    {
        activate.Emit += Activate;
        deactivate.Emit += Deactivate;
    }

    public void Activate()
    {
        Debug.LogFormat("{0}: activate", name);

        body.velocity = velocity;
        // todo: force child class to adopt
    }

    public void Deactivate()
    {
        Debug.LogFormat("{0}: deactivate", name);

        body.velocity = Vector2.zero;
    }

    [SerializeField]
    public Vector2 velocity;

    [SerializeField]
    public Rigidbody2D body;
}
