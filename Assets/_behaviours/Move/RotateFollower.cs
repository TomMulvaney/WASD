using UnityEngine;
using System.Collections;
// TODO:
// 1. Rename
// 2. SerializeField: m_transformMatch: up, down, forward, backward, left and right
// 3. SerializeField: m_rotateSpeed = -1 (if -1 then instant)
public class RotateFollower : MonoBehaviour 
{	
    Vector3 m_lastPos;

	void Update () 
    {
        Vector3 velocity = transform.position - m_lastPos;

        if (!MathHelpers.Approximately(velocity, Vector3.zero))
        {
            transform.up = velocity;
        }

        m_lastPos = transform.position;
	}
}
