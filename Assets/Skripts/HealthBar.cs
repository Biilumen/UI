using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;
    [SerializeField] private Slider _slider;

    private float _health;

    private void Start()
    {
        _health = _maxHealth;
    }

    private IEnumerator SliderValueChnge()
    {
        while (_slider.value != _health)
        {
        _slider.value = Mathf.MoveTowards(_slider.value, _health, 10f * Time.deltaTime);
        yield return null;
        }
        StopCoroutine(SliderValueChnge());
    }

    private void CoroutineStart()
    {
        var coroutineJob = StartCoroutine(SliderValueChnge());
    }

   
    public void TakeHeal()
    {
        if (_health < _maxHealth)
        {
            _health += _power;
        }
        CoroutineStart();
    }

    public void TakeDamage()
    {
        if (_health > _minHealth)
        {
            _health -= _power;
        }
        CoroutineStart();
    }
}
