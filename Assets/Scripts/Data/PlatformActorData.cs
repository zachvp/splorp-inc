using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlatformActorData", menuName = "Data/PlatformActorData")]
public class PlatformActorData : Data
{
    public PlatformActorState state;

    public Vector2 up;

    public void Clear()
    {
        state = PlatformActorState.NONE;
        up = Vector2.zero;
    }
}
