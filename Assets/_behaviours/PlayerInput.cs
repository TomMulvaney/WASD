using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour 
{
	public virtual Vector2 GetVector2()
	{
		return Vector2.zero;
	}

    public virtual Vector3 GetVector3()
    {
        return Vector3.zero;
    }
}
