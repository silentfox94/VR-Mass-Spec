using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivateBeams : MonoBehaviour
{
    public UnityEvent OnSampleInserted;

    private void Update()
    {
        OnSampleInserted?.Invoke();
    }
}
