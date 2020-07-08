using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyParticleHandler : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem[] particlesSystems;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayParticleSystem()
    {
        ParticleSystem ps = particlesSystems[Random.Range(0, particlesSystems.Length)];
        while (ps.isEmitting)
        {
            ps = particlesSystems[Random.Range(0, particlesSystems.Length)];
        }
        ps.Play();
    }
}
