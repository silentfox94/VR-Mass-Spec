using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MSEquationManager : MonoBehaviour
{
    public Slider massSlider, velocitySlider, chargeSlider, magneticFieldStrengthSlider;

    public float mass;
    public float velocity;
    public float charge;
    public float magneticFieldStrength;

    public TextMeshProUGUI massValueText, velocityValueText, chargeValueText, magneticFieldStrengthValueText;

    private void Update()
    {
        UpdateValues();
    }

    public void UpdateValues()
    {
        mass = TwoDecimalRound(massSlider.value);
        velocity = TwoDecimalRound(velocitySlider.value);
        charge = TwoDecimalRound(chargeSlider.value);
        magneticFieldStrength = TwoDecimalRound(magneticFieldStrengthSlider.value);

        massValueText.text = mass.ToString();
        velocityValueText.text = velocity.ToString();
        chargeValueText.text = charge.ToString();
        magneticFieldStrengthValueText.text = magneticFieldStrength.ToString();

    }

    public float TwoDecimalRound(float value)
    {
        return Mathf.Round(value * 100f) / 100f;
    }
}
