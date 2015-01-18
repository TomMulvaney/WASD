using UnityEngine;
using System.Collections;

public class WASDInput : PlayerInput
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
}
