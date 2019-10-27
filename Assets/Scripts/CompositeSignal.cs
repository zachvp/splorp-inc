using UnityEngine;

public class CompositeSignal : Signal
{
    [SerializeField]
    public Signal lhs;

    [SerializeField]
    public Signal rhs;

    [SerializeField]
    public Logic logic;

    private bool lhsResult;
    
    private bool rhsResult;

    public void Awake()
    {
        lhs.Emit += OnLhsEmit;
        rhs.Emit += OnRhsEmit;
    }

    public void LateUpdate()
    {
        switch (logic)
        {
            case Logic.AND:
                if (lhsResult && rhsResult)
                {
                    Events.Raise(Emit);
                }
                break;
            case Logic.OR:
                if (lhsResult || rhsResult)
                {
                    Events.Raise(Emit);
                }
                break;
            case Logic.XOR:
                if ((lhsResult || rhsResult) && !(lhsResult && rhsResult))
                {
                    Events.Raise(Emit);
                }
                break;
        }

        lhsResult = false;
        rhsResult = false;
    }

    public void OnLhsEmit()
    {
        lhsResult = true;
    }

    public void OnRhsEmit()
    {
        rhsResult = true;
    }
}
