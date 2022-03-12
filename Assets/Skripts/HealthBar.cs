using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

  
    private IEnumerator ChngeSliderValue()
    {
        while (_slider.value != _player.Health)
        {
        _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, 10f * Time.deltaTime);
        yield return null;
        }
    }

    public void CangeHealthBar()
    {
        var coroutineJob = StartCoroutine(ChngeSliderValue());
    }
}
