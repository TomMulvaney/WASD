using UnityEngine;
using System.Collections;

public static class MathHelpers
{
    public static bool SameSign(float a, float b)
    {
        return Mathf.Approximately(a * b, Mathf.Abs(a) * Mathf.Abs(b));
    }
}
