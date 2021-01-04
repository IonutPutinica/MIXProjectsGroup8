using System;
using System.Collections;
using System.Security.AccessControl;
using UnityEngine;

public class FireScenario : MonoBehaviour
{
    public ParticleSystem smokeParticle;
    public ParticleSystem fireParticle;
    public GameObject fireSource;

    private ParticleSystem _smokeObject;
    private ParticleSystem _fireObject;
    private FireScript _fireScript;
    private FireAlarmSoundFX _fireAlarmSoundFX;
    private FireFX _fireFX;

    private void Start()
    {
        _fireScript = GameObject.FindObjectOfType<FireScript>();
        _fireAlarmSoundFX = GameObject.FindObjectOfType<FireAlarmSoundFX>();
        _fireFX = GameObject.FindObjectOfType<FireFX>();
    }

    public IEnumerator StartFire()  //can only start the fire if it is stopped
    {
        var position = fireSource.transform.position;
        _smokeObject = Instantiate(smokeParticle, position, Quaternion.identity);
        yield return new WaitForSeconds(3f);

        StartCoroutine(_fireScript.FireHealthRegen());
        _fireObject = Instantiate(fireParticle, position, Quaternion.identity);

        _smokeObject.Stop();
        _fireAlarmSoundFX.FireAlarmStart();
        _fireFX.AmbientSmokeStart();
        
        yield return null;
    }
    public IEnumerator StopFire() // can only stop if the fire is already started
    {
        _smokeObject.Play();
        _fireObject.Stop();
        Destroy(_fireObject);

        yield return new WaitForSeconds(3f);
        _smokeObject.Stop();
        Destroy(_smokeObject);
        
        _fireFX.AmbientSmokeStop();
        _fireAlarmSoundFX.FireAlarmStop();

        yield return null;
    }
}
