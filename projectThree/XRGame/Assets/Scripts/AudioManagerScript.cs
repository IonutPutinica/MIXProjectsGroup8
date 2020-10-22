using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    public SoundScript[] sounds;
    public static AudioManagerScript instance; 

    private void Awake()
    {
        // If this Game Object does not exist, then create it.  Otherwise destroy any duplicates.
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        // Ensures that the Game Object will persist between scenes once instantiated.
        DontDestroyOnLoad(gameObject);

        // For each sound in the SoundScript array
        foreach (SoundScript singleSound in sounds)
        {
            // Expose the necessary attributes here.  Nothing here yet though. :(
        }
    }

    public void Play(string name)
    {
        //Goes through the array of SoundScript and finds the sounds by name.
        //The code is commented because the array is empty and throws errors.  We aren't using it yet.
        /*
        SoundScript s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound by Name: " + name + "was not found!");
            return;
        }
        s.source.Play();
        */
    }

    // Start is called before the first frame update
    void Start()
    {
        //We can put background music here and it will play from this Game Object.
        //For example: Play("BackgroundMusic"); 
    }
}
