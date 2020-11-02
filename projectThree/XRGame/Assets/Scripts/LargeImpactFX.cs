using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeImpactFX : MonoBehaviour
{
    //The audio played here is tied to a particular game object
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            //play audio
        }
    }
}
