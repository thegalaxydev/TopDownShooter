using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIBehavior : MonoBehaviour
{
    [SerializeField]
    private HealthBehaviour _healthBehaviour;
    private Slider _slider;
    [SerializeField]
    private Text _healthText;
    [SerializeField]
    private Gradient _gradient;
    [SerializeField]
    private Image _fill;


    private 

    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _healthBehaviour.Health;
        _healthText.text = _healthBehaviour.Health + " / " + _slider.maxValue.ToString();

        _fill.color = _gradient.Evaluate(1f);
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _healthBehaviour.Health;
        _healthText.text = _healthBehaviour.Health + " / " + _slider.maxValue.ToString();

        _fill.color = _gradient.Evaluate(_slider.value / _slider.maxValue);
    }
}
