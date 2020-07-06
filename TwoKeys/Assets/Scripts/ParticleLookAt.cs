using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLookAt : MonoBehaviour
{

    private ParticleSystem particleSystem;
    private ParticleSystem.Particle[] particles;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void LateUpdate()
    {
        InitializeIfNeeded();

        int numParticlesAlive = particleSystem.GetParticles(particles);

        for (int i = 0; i < numParticlesAlive; i++)
        {
            particles[i].rotation = Vector3.Angle( particles[i].position - transform.position, Vector3.forward);
        }

        particleSystem.SetParticles(particles, numParticlesAlive);
    }

    void InitializeIfNeeded()
    {
        if (particleSystem == null)
            particleSystem = GetComponent<ParticleSystem>();

        if (particles == null || particles.Length < particleSystem.main.maxParticles)
            particles = new ParticleSystem.Particle[particleSystem.main.maxParticles];
    }

}
