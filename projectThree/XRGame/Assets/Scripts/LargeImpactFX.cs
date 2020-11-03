using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeImpactFX : MonoBehaviour
{
    //The audio played here is tied to a particular game object

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Debug.Log("COLLISION DETECTED!");
            AudioManagerScript.instance.Play("LargeObjectHit");
        }
    }
}
