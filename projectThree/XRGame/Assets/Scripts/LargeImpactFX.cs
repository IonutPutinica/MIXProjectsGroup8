using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeImpactFX : MonoBehaviour
{
    //The audio played here is tied to a particular game object

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            AudioManagerScript.instance.Play("LargeObjectHit");
        }
    }
}
