using UnityEngine;
using System.Collections;

public class FourKeyXYInput : PlayerInput
{
    [SerializeField]
    private KeyCode m_xPlus = KeyCode.D;
    [SerializeField]
    private KeyCode m_xMinus = KeyCode.A;
    [SerializeField]
    private KeyCode m_yPlus = KeyCode.W;
    [SerializeField]
    private KeyCode m_yMinus = KeyCode.S;

	public override Vector2 GetVector2 ()
	{
		Vector2 vec = Vector2.zero;

		if(Input.GetKey(m_yPlus))
		{
			vec.y += 1;
		}

		if (Input.GetKey (m_yMinus)) 
		{
			vec.y -= 1;
		}

		if(Input.GetKey(m_xPlus))
		{
			vec.x += 1;
		}
		
		if (Input.GetKey (m_xMinus)) 
		{
			vec.x -= 1;
		}

		return vec;
	}

    public override Vector3 GetVector3()
    {
        Vector2 vec2 = GetVector2();

        return new Vector3(vec2.x, vec2.y, 0);
    }
}
