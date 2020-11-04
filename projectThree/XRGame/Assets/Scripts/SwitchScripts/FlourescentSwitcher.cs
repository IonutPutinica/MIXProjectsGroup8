using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourescentSwitcher : MonoBehaviour
{
    public Material materialSwap1;
    public Material materialSwap2;

    [SerializeField]
    private MeshRenderer original; //need to get it at element 1 in the light prefab

    public void SetToOn()
    {
        original.material = materialSwap1;
    }
    public void SetToOff()
    {
        original.material = materialSwap2;
    }
}
