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
        smokeObject = Instantiate(smokeParticle, fireSource.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3f);
        fireObject = Instantiate(fireParticle, fireSource.transform.position, Quaternion.identity);
        //might need to parent these gameobjects to the pan.

        smokeObject.Stop();
        Destroy(smokeObject);
    }
    public IEnumerator StopFire()
    {
        fireObject.Stop();
        Destroy(fireObject);
        yield return null;
    }
}
