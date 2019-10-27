using System.Collections.Generic;

public static class Utilities
{
    public static bool IsDataChanged<T>(T lhs, T rhs)
    {
        return !EqualityComparer<T>.Default.Equals(lhs, rhs);
    }
}