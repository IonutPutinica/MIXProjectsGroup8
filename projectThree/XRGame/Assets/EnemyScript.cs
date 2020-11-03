using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{

    public GameObject player;
    public int maxHealth;
    private int currentHealth;
    public float speed;

    private void chasePlayer()
    {
        transform.LookAt(player.transform.position);

        if (Vector3.Distance(transform.position, player.transform.position) >= 1)
        {

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(this);
            // do something to tell player he won and killed the baddie I guess
        }
        else
        {
            chasePlayer();
        }
    }
}
