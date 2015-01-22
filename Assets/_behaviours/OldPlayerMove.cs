using UnityEngine;
using System.Collections;

public class OldPlayerMove : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D m_reference;
	[SerializeField]
	private PlayerInput m_input;
	[SerializeField]
	private float m_maxSpeed;
    [SerializeField]
    private float m_acceleration;

	void FixedUpdate()
	{
		Vector2 move = m_input.GetVector2 ().normalized;

        // Impulse
        Vector2 impulse = Vector2.zero;
        
        if(!MathHelpers.SameSign(move.x, rigidbody2D.velocity.x))
        {
            impulse.x = -rigidbody2D.velocity.x;
        }
        
        if(!MathHelpers.SameSign(move.y, rigidbody2D.velocity.y))
        {
            impulse.y = -rigidbody2D.velocity.y;
        }
        
        rigidbody2D.AddForce(impulse, ForceMode2D.Impulse);
        
        // Force
        rigidbody2D.AddForce (m_reference.GetRelativeVector (move) * m_acceleration);
        
        // Limit velocity           
        if (m_reference.GetRelativeVector (rigidbody2D.velocity).magnitude >= m_maxSpeed) 
        {
            rigidbody2D.velocity = rigidbody2D.velocity.normalized * m_maxSpeed;        
        }
	}
}
