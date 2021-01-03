using UnityEngine;

public class FireFX : MonoBehaviour
{
    public ParticleSystem roomSmoke;
    public AudioSource fireSound;

    public void AmbientSmokeStart()
    {
        roomSmoke.Play();
    }

    public void AmbientSmokeStop()
    {
        roomSmoke.Stop();
    }
    

}