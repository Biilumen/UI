using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private Slider _slider;

    private float _targetValue;

    private void Start()
    {
        _targetValue = _slider.value;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, 10f * Time.deltaTime);
    }

    public void OnHealButtonClick()
    {
        if (_targetValue < _slider.maxValue)
        {
        _targetValue += _power;
        }
    }

    public void OnDamageButtonClick()
    {
        if (_targetValue > _slider.minValue)
        {
        _targetValue -= _power;
        }
    }
}
