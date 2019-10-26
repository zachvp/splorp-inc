using UnityEngine;

[CreateAssetMenu(fileName = "PlayerControlData", menuName = "Data/PlayerControlData", order = 1)]
public class PlayerControlData : ScriptableObject
{
    public DigitalControl control1;

    public PlayerControlData()
    {
        control1.action = PlayerControlAction.Action1;
    }

    public void Clear()
    {
        control1.state = ControlState.NONE;
    }
}
