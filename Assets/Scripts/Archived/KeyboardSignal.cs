using UnityEngine;

public class KeyboardSignal : Signal
{
    [SerializeField]
    public KeyCode key;

    [SerializeField]
    public ControlState state;

    public void Update()
    {
        // todo: cleanup
        if (state == ControlState.PRESSED && Input.GetKeyDown(key) ||
            state == ControlState.HELD && Input.GetKey(key) ||
            state == ControlState.RELEASED && Input.GetKeyUp(key))
        {
            Events.Raise(Emit);
        }
    }
}
