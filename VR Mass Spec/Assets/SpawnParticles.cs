using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticles : MonoBehaviour
{
    public float timer = 0f;
    public GameObject particlePrefab;
    public int particleCount = 0;
    private void Start()
    {
        timer = 0f;
        particleCount = 0;
        
    }

    private void Update()
    {
        
    }

    void Spawn50Particles()
    {
        timer += Time.deltaTime;

        if (timer % 2 == 0)
        {

        }
    }
}
