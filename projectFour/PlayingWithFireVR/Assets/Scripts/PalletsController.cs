using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PalletsController : MonoBehaviour
{
    public Transform palletsFire1;
    public Transform palletsFire2;
    private void OnParticleCollision(GameObject other)
    {
        ParticleSystem emissionModule1 = palletsFire1.GetComponent<ParticleSystem>();
        ParticleSystem emissionModule2 = palletsFire2.GetComponent<ParticleSystem>();
        emissionModule1.Stop();
        emissionModule2.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
