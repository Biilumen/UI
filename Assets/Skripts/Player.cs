using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public Action HelthChangeEvent;
    public float Health { get; private set; }

    private void Start()
    {
        Health = _maxHealth;
    }

    private void Update()
    {
        Debug.Log(Health);
    }

    public void TakeHeal()
    {
        Health = Mathf.Clamp(Health + _power ,_minHealth, _maxHealth);
        HelthChangeEvent?.Invoke();
    }

    public void TakeDamage()
    {
        Health = Mathf.Clamp(Health - _power, _minHealth, _maxHealth);
        HelthChangeEvent?.Invoke();
    }
}
