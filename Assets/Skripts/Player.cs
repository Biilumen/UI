using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public float Health { get; private set; }

    public Action HelthChanged;

    private void Start()
    {
        Health = _maxHealth;
    }

    public void TakeHeal()
    {
        Health = Mathf.Clamp(Health + _power ,_minHealth, _maxHealth);
        HelthChanged?.Invoke();
    }

    public void TakeDamage()
    {
        Health = Mathf.Clamp(Health - _power, _minHealth, _maxHealth);
        HelthChanged?.Invoke();
    }
}
