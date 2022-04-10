using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using PathCreation;
public class MSEquationManager : MonoBehaviour
{
    public Slider magneticFieldStrengthSlider;

    public float mass;
    public float velocity;
    public float charge;
    public float magneticFieldStrength;

    public TextMeshProUGUI massValueText, velocityValueText, chargeValueText, magneticFieldStrengthValueText;

    public PathCreator pathCreator;
    private void Update()
    {
        UpdateValues();
    }
    private void Start()
    {
        PrintBezierPoints();
    }
    public void PrintBezierPoints()
    {
        for (int i = 0; i <= pathCreator.bezierPath.NumPoints-1; i++ )
        print("Bezier Point Index " + i + " is: " + pathCreator.bezierPath.GetPoint(i));
    }
    public void UpdateValues()
    {
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
