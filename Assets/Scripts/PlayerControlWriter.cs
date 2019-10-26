using UnityEngine;
using InControl;

// todo: rename to GamepadControlWriter?
public class PlayerControlWriter : MonoBehaviour
{
    [SerializeField]
    public PlayerControlData data;

    public void Update()
    {
        var gamepad = InputManager.ActiveDevice;

        if (gamepad.Action1.WasPressed)
        {
            Debug.Log("action 1 pressed");
            data.control1.state = ControlState.PRESSED;
        }
    }

    public void LateUpdate()
    {
        data.Clear();
    }
}
