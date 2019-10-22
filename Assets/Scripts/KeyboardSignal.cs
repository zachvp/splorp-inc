using UnityEngine;

public class KeyboardSignal : Signal
{
    [SerializeField]
    public KeyCode key;

    public void Update()
    {
        if (Input.GetKeyDown(key))
        {
            foreach (Receiver receiver in receivers)
            {
                receiver.Fire();
            }
        }
    }
}
