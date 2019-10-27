using UnityEngine;
using InControl;

// todo: rename to GamepadControlWriter?
public class GamepadControlWriter : MonoBehaviour
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

        Events.Raise(data.OnChange);
    }

    public void LateUpdate()
    {
        data.Clear();
    }
}
