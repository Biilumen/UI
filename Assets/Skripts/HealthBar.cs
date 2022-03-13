using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _player.Health;
        _slider.value = _player.Health;
    }

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
