using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DespawnTimer()
    {
        //StartCoroutine(Despawn());
    }   
    
    private IEnumerator Despawn()
    {
        yield return new WaitForSeconds(5f);
        //Access GameObject instance from another script to destroy it?
        //May have to move CheckCube method to have access to instances...
    }
}
