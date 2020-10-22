using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[System.Serializable]
public class SoundScript  //The MonoBehavior was deleted for a reason.  This is not a script.  I will scream if I see it added back.
{
    public string name;
    public AudioClip clip;

    // This class is used to define and expose AudioClip attributes in the Audio Manager.
    // Add attributes such as volume, range, etc as needed.
    // I already added name and clip because we need those at the very least. XD
}
