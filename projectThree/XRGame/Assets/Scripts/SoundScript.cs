using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[System.Serializable]
public class SoundScript  //The MonoBehavior was deleted for a reason.  This is not a script.  I will scream if I see it added back.
{
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
    // This class is used to define and expose AudioClip attributes in the Audio Manager.
    // Add attributes such as volume, range, etc as needed.
}
