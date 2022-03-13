using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    [SerializeField] private UnityEvent OnHelthChnge;

    public float Health { get; private set; }

    private void Start()
    {
        Health = _maxHealth;
    }

    public void TakeHeal()
    {
        Health += _power;
        Health = Mathf.Clamp(Health ,_minHealth, _maxHealth);
        OnHelthChnge.Invoke();
    }

    public void TakeDamage()
    {
        Health -= _power;
        Health = Mathf.Clamp(Health, _minHealth, _maxHealth);
        OnHelthChnge.Invoke();
    }
}
