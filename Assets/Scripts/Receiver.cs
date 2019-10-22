using UnityEngine;

public class Receiver : MonoBehaviour
{
    public virtual void Fire()
    {
        Debug.LogFormat("{0}: fired", name);
    }
}
