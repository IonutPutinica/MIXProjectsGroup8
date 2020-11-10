using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{

    public Transform fireExtinguisher;
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem emissionModule = fireExtinguisher.GetComponent<ParticleSystem>();
        emissionModule.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem emissionModule = fireExtinguisher.GetComponent<ParticleSystem>();
        emissionModule.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        ParticleSystem emissionModule = fireExtinguisher.GetComponent<ParticleSystem>();
        emissionModule.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
