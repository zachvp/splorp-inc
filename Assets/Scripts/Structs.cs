using UnityEngine;

public struct DigitalControl
{
    public PlayerControlAction action;
    public ControlState state;
}

public struct AnalogControl
{
    public PlayerControlAction action;
    public Vector2 value;
}
