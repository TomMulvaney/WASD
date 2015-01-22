using UnityEngine;
using System.Collections;

public class KeyInput : PlayerInput
{
    [SerializeField]
    private KeyCode m_onKey;

	public override bool IsOn()
    {
        return Input.GetKey(m_onKey);
    }
}
