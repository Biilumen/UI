using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _MaxHelth;
    [SerializeField] private float _MinHelth;

    public float _helth { get; private set; }

    private void Start()
    {
        _helth = _MaxHelth;
    }

    public void OnHealButtonClick()
    {
        if (_helth < _MaxHelth)
        {
            _helth += _power;
        }
    }

    public void OnDamageButtonClick()
    {
        if (_helth > _MinHelth)
        {
            _helth -= _power;
        }
    }
}
