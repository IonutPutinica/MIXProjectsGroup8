using System.Collections;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public int fireHealth;                             // starting fire health
    public float currentHealth;                        // current health of the fire
    public int fireRegenRate;
    private bool _fireTookDamage;                       // if the fire has recently taken damage
    public int damageNumberPerParticle;
    private int _particleCollisions = 0;

    private FireFX _fireFX;
    private FireScenario _fireScenario;

    private void OnParticleCollision(GameObject other) {
        if (other.CompareTag("ExtinguishAll")) {
            _fireTookDamage = true;
            _particleCollisions++;
        }
    }

    // Start is called before the first frame update
    void Start() {
        currentHealth = fireHealth;
        _fireFX = GameObject.FindObjectOfType<FireFX>();
        _fireScenario = GameObject.FindObjectOfType<FireScenario>();
    }
    
    // Update is called once per frame
    void Update() {
        if (_fireTookDamage) {
            currentHealth -= damageNumberPerParticle * _particleCollisions * Time.deltaTime;
            _fireTookDamage = false;
            _particleCollisions = 0;
            
            if (currentHealth <= 0) {
                StartCoroutine(_fireScenario.StopFire());
            }
        }
        else if (_fireFX.roomSmoke.isPlaying && currentHealth <= fireHealth)
            StartCoroutine(FireHealthRegen());
        
        _fireFX.fireSound.volume = currentHealth / 120;
    }
    
    public IEnumerator FireHealthRegen()
    {
        while (_fireFX.roomSmoke.isPlaying && currentHealth < fireHealth && currentHealth != 0)
        {
            currentHealth += fireRegenRate * Time.deltaTime;
        }

        yield return null;
    }
}