using UnityEngine;
using System.Collections;

public class WASDTopDown : PlayerInput
{
	public override Vector2 GetVector2 ()
	{
		Vector2 vec = Vector2.zero;

		if(Input.GetKey(KeyCode.W))
		{
			vec.y += 1;
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			vec.y -= 1;
		}

		if(Input.GetKey(KeyCode.D))
		{
			vec.x += 1;
		}
		
		if (Input.GetKey (KeyCode.A)) 
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
