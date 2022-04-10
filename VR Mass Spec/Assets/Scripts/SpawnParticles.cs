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
        //Spawn50Particles();
    }

    void Spawn50Particles()
    {
        timer += Time.deltaTime;
        if (Mathf.Floor(timer) % 100 == 0)
        {
            Instantiate(particlePrefab);
            particleCount++;
            if (particleCount >= 50)
            {
                Destroy(this);
            }
        }
        
    }
}
