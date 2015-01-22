using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private CharacterController m_control;
    [SerializeField]
    private PlayerInput m_input;
    [SerializeField]
    private bool m_useLocalSpace = true;
    [SerializeField]
    private float m_maxSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 move = m_input.GetVector3().normalized;

        if (m_useLocalSpace)
        {
            move = transform.TransformVector(move);
        }

        // TODO: m_maxSpeed does not work properly for local space
        move *= m_maxSpeed;

        m_control.Move(move);
	}

    void OnGUI()
    {
        GUILayout.Label("GlobalSpeed: " + m_control.velocity.magnitude);
        GUILayout.Label("LocalSpeed: " + transform.InverseTransformVector(m_control.velocity).magnitude);
    }
}
