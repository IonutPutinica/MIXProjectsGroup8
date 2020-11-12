using UnityEngine;

public class FireScript : MonoBehaviour
{

    public int fireHealth;
    private float currentHealth;
    public int fireRegenRate;
    private bool takenDamage;
    public int damageNumberPerParticle;
    private int particlesHit = 0;
    private ParticleSystem[] particleSystems;

    public ParticleSystem externalSmoke;

    public GameObject fireAlarm;


    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("ExtinguishAll"))
        {
            //Debug.Log("Works");
            takenDamage = true;
            particlesHit++;

        }
    }

    private void killAllParticles()
    {
        for (int i = 0; i < particleSystems.Length; i++)
        {
            particleSystems[i].Stop(); //disables any new particles that might be generated
            Debug.Log(particleSystems[i] + "has been stopped");
        }
        externalSmoke.Stop();
        fireAlarm.GetComponent<AudioSource>().loop = false;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fireHealth;
        particleSystems = GetComponentsInChildren<ParticleSystem>(true);
        for (int i = 0; i < particleSystems.Length; i++)
        {
            //Debug.Log(particleSystems[i].gameObject.name);
        }
        externalSmoke.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (takenDamage)
        {
            currentHealth -= damageNumberPerParticle * particlesHit * Time.deltaTime;
            takenDamage = false;
            particlesHit = 0;
        }
        else
        {
            if (currentHealth <= fireHealth)
                currentHealth += fireRegenRate * Time.deltaTime;
        }
        //Debug.Log("Current health: " + currentHealth);
        if (currentHealth <= 0)
        {
            fireRegenRate = 0;
            //Debug.Log("Fire iz ded");
            killAllParticles();
        }

        GetComponent<AudioSource>().volume = currentHealth / 100;
    }
}
