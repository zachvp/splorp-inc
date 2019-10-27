using UnityEngine;

public class PlatformActorSignal : Signal
{
    [SerializeField]
   public PlatformActorData data;

    [SerializeField]
   public PlatformActorState state;

    public void Awake()
    {
        data.OnChange += HandleOnChange;
    }

    public void HandleOnChange()
    {
        if (data.state == state)
        {
            Debug.LogFormat("platform actor signal triggered");
            Events.Raise(Emit);
        }
    }
}
