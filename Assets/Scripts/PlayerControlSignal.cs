using UnityEngine;

public class PlayerControlSignal : Signal
{
    [SerializeField]
    public PlayerControlData data;

    public PlayerControlAction action;

    public ControlState state;

    public void Update()
    {
        if (data.control1.state == state && data.control1.action == action)
        {
            Events.Raise(Emit);
        }
    }
}
