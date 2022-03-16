using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public Action OnHelthChange;
    public float Health { get; private set; }

    private void Start()
    {
        Health = _maxHealth;
    }

    public void TakeHeal()
    {
        Health += _power;
        Health = Mathf.Clamp(Health ,_minHealth, _maxHealth);
        OnHelthChange?.Invoke();
    }

    public void TakeDamage()
    {
        Health -= _power;
        Health = Mathf.Clamp(Health, _minHealth, _maxHealth);
        OnHelthChange?.Invoke();
    }
}
