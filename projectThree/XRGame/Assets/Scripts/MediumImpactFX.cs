using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumImpactFX : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Debug.Log("MEDIUM COLLISION DETECTED!");
            AudioManagerScript.instance.Play("MediumObjectHit");
        }
    }
}
