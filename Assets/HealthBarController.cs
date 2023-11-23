using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    float _currentHealth;
    float _maxHealth;

    Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponentInChildren<Slider>();
        _maxHealth = _slider.maxValue;
        _currentHealth = _maxHealth;

        UpdateHealthBar();
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        if( _currentHealth <= 0 )
        {
            //lose life
        }

        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        _slider.value = _currentHealth;
    }  
    
    void ResetHealth()
    {
        _currentHealth = _maxHealth;

        UpdateHealthBar();
    }
}
