using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IonBeamManager : MonoBehaviour
{
    public ParticleSystem ionBeamParticleSystem;
    public Slider magneticFieldStrengthSlider;
    Keyframe[] keys;
    AnimationCurve curve;

    private void Start()
    {
        AnimationCurve curve = new AnimationCurve();
        keys = new Keyframe[2];
        keys[0] = new Keyframe(0.0f, 0.0f);
        keys[1] = new Keyframe(1.0f, 1.0f);
        curve.AddKey(keys[0]);
        curve.AddKey(keys[1]);
    }
    private void Update()
    {
        ChangeParticlePath(magneticFieldStrengthSlider.value);
    }

    public void ChangeParticlePath(float magneticFieldStrength)
    {
        
        keys[1] = new Keyframe(1.0f, magneticFieldStrengthSlider.value);
        var velocity = ionBeamParticleSystem.velocityOverLifetime.z;
        curve.MoveKey(1, keys[1]);

    }
}
