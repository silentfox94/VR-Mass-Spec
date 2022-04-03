using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageBeamVelocity : MonoBehaviour
{
	private ParticleSystem ps;
	public float hSliderValueX = 1.0f;
	public float hSliderValueY = 1.0f;
	public float hSliderValueZ = 1.0f;

	AnimationCurve xCurve;
	AnimationCurve yCurve;
	AnimationCurve zCurve;

	public Slider magneticFieldStrengthSlider;

	void Start()
	{
		ps = GetComponent<ParticleSystem>();

		var velocityOverLifetime = ps.velocityOverLifetime;
		velocityOverLifetime.enabled = true;
		velocityOverLifetime.space = ParticleSystemSimulationSpace.Local;

		xCurve = new AnimationCurve();
		xCurve.AddKey(0.0f, 0.0f);
		xCurve.AddKey(1.0f, 1.0f);

		yCurve = new AnimationCurve();
		yCurve.AddKey(0.0f, 0.0f);
		yCurve.AddKey(1.0f, 1.0f);

		zCurve = new AnimationCurve();
		zCurve.AddKey(0.0f, 0.0f);
		zCurve.AddKey(1.0f, magneticFieldStrengthSlider.value);


        ParticleSystem.MinMaxCurve xMinMaxCurve = new ParticleSystem.MinMaxCurve(1.0f, xCurve);
		ParticleSystem.MinMaxCurve yMinMaxCurve = new ParticleSystem.MinMaxCurve(1.0f, yCurve);
		ParticleSystem.MinMaxCurve zMinMaxCurve = new ParticleSystem.MinMaxCurve(1.0f, zCurve);

		velocityOverLifetime.x = xMinMaxCurve;
		velocityOverLifetime.y = yMinMaxCurve;
		velocityOverLifetime.z = zMinMaxCurve;


	}

	void Update()
	{
		var velocityOverLifetime = ps.velocityOverLifetime;

		Keyframe[] keys = new Keyframe[3];
		keys[0] = new Keyframe(0.0f, 0.0f);
		keys[1] = new Keyframe(0.5f, 0.1f);
		keys[2] = new Keyframe(1.0f, magneticFieldStrengthSlider.value);



		zCurve = new AnimationCurve(keys);


		

		ParticleSystem.MinMaxCurve zMinMaxCurve = new ParticleSystem.MinMaxCurve(1.0f, zCurve);
		velocityOverLifetime.z = zMinMaxCurve;
		velocityOverLifetime.xMultiplier = hSliderValueX;
		velocityOverLifetime.yMultiplier = hSliderValueY;
		velocityOverLifetime.zMultiplier = hSliderValueZ;

		
	}

}
