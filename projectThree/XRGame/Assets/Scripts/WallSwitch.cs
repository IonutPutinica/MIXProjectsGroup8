using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Material materialSwap1;
    public Material materialSwap2;

    [SerializeField]
    private MeshRenderer original;
    private bool swapped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!swapped)
            {
                original.material = materialSwap1;
                swapped = true;
            }
            else if (swapped)
            {
                original.material = materialSwap2;
                swapped = false;
            }
        }
    }
}
