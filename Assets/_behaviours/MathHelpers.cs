using UnityEngine;
using System.Collections;

public static class MathHelpers
{
    public static bool SameSign(float a, float b)
    {
        return Mathf.Approximately(a * b, Mathf.Abs(a) * Mathf.Abs(b));
    }

    public static bool Approximately(Vector2 a, Vector2 b)
    {
        return Mathf.Approximately(a.x, b.x) && Mathf.Approximately(a.y, b.y);
    }

    public static bool Approximately(Vector3 a, Vector3 b)
    {
        return Mathf.Approximately(a.x, b.x) && Mathf.Approximately(a.y, b.y) && Mathf.Approximately(a.z, b.z);
    }
}
