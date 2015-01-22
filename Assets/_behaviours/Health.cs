using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
    [SerializeField]
    private int m_maxHealth = 100;
    [SerializeField]
    UISlider m_slider;

    private int m_currentHealth;

	// Use this for initialization
	void Awake () 
    {
        m_currentHealth = m_maxHealth;
	}

    public void ChangeHealth(int delta)
    {
        m_currentHealth += delta;
        m_slider.value = (float)m_currentHealth / (float)m_maxHealth;
    }
}
