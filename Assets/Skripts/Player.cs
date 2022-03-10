using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public float Health { get; private set; }

    private void Start()
    {
        Health = _maxHealth;
    }

    public void TakeHeal()
    {
        if (Health < _maxHealth)
        {
            Health += _power;
        }
        Debug.Log(Health);
    }

    public void TakeDamage()
    {
        if (Health > _minHealth)
        {
            Health -= _power;
        }
        Debug.Log(Health);
    }
}
