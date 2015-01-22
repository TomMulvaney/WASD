using UnityEngine;
using System.Collections;

public class KeyDownInput : PlayerInput
{
    [SerializeField]
    private KeyCode m_onKey;

    public override bool IsOn()
    {
        return Input.GetKeyDown(m_onKey);
    }
}
