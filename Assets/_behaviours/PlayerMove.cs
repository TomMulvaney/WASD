using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private CharacterController m_control;
    [SerializeField]
    private PlayerInput m_directionalInput;
    [SerializeField]
    private PlayerInput m_switchInput;
    [SerializeField]
    private bool m_useLocalSpace = true;
    [SerializeField]
    private float m_maxSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        bool canMove = m_switchInput == null || m_switchInput.IsOn();

        if (canMove)
        {
            Vector2 move = m_directionalInput.GetVector3().normalized * m_maxSpeed;

            if (m_useLocalSpace)
            {
                move = transform.TransformVector(move);
            }

            m_control.Move(move);
        }
	}
}
