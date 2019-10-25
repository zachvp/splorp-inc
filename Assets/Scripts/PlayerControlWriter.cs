using UnityEngine;
using InControl;

public class PlayerControlWriter : MonoBehaviour
{
    [SerializeField]
    public PlayerControlData data;

    public void Update()
    {
        var gamepad = InputManager.ActiveDevice;

        data.action1 = gamepad.Action1.IsPressed;
    }
}
