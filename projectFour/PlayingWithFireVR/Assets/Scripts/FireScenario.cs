using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScenario : MonoBehaviour
{
    public ParticleSystem smokeParticle;
    public ParticleSystem fireParticle;
    public GameObject fireSource;

    private ParticleSystem smokeObject;
    private ParticleSystem fireObject;

    public IEnumerator StartFire()
    {
        Debug.Log("FireStarted.");
        yield return null;
    }
        
}
