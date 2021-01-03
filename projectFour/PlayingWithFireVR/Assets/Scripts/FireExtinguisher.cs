using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    public bool spewing;
    public ParticleSystem fireExtinguisherFoam;
    public AudioSource fireExtinguisher;

    public void Toggle()
    {
        spewing = !spewing;

        if (spewing)
        {
            fireExtinguisherFoam.Play();
            fireExtinguisher.Play();
        }
        else
        {
            fireExtinguisherFoam.Stop();
            fireExtinguisher.Stop();
        }
    }
}