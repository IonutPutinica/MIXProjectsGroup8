﻿using UnityEngine;

public class FireScript : MonoBehaviour
{
    public int fireHealth;                             // starting fire health
    public float currentHealth;                        // current health of the fire
    public int fireRegenRate;
    private bool fireTookDamage;                       // if the fire has recently taken damage
    public int damageNumberPerParticle;
    private int particleCollisions = 0;
    private ParticleSystem[] panParticleSystems;
    public ParticleSystem externalSmoke;               // ambient smoke
    public GameObject fireAlarm;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("ExtinguishAll"))
        {
            fireTookDamage = true;
            particleCollisions++;
        }
    }
    
    private void StopPanParticleSystems()
    {
        for (int i = 0; i < panParticleSystems.Length; i++)
        {
            panParticleSystems[i].Stop();
        }
    }

    private void StopFireAlarm()
    {
        fireAlarm.GetComponent<AudioSource>().loop = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fireHealth;
        panParticleSystems = GetComponentsInChildren<ParticleSystem>(true); // get all "Pan" particle systems
    }
    
    // Update is called once per frame
    void Update()
    {
        if (fireTookDamage)
        {
            currentHealth -= damageNumberPerParticle * particleCollisions * Time.deltaTime;
            fireTookDamage = false;
            particleCollisions = 0;
            
            if (currentHealth <= 0)
            {
                StopPanParticleSystems();
                externalSmoke.Stop();
                Invoke("StopFireAlarm", 5);
            }
        }
        else
        {
            if(externalSmoke.isPlaying && currentHealth <= fireHealth)
                currentHealth += fireRegenRate * Time.deltaTime;
        }

        GetComponent<AudioSource>().volume = currentHealth / 120;
    }
}