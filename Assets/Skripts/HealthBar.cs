using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private void Start()
    {
        _slider.maxValue = _player.Health;
    }

    private void FixedUpdate()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, 10f * Time.deltaTime);
    }
}
