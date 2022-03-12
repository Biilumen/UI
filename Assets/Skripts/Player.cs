using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    [SerializeField] private UnityEvent OnHelthChnge;

    public float Health { get; private set; }

    void Start()
    {
        Health = _maxHealth;
    }

    public void TakeHeal()
    {
        if (Health < _maxHealth)
        {
            Health += _power;
        }
        OnHelthChnge.Invoke();
    }

    public void TakeDamage()
    {
        if (Health > _minHealth)
        {
            Health -= _power;
        }
        OnHelthChnge.Invoke();
    }
}
