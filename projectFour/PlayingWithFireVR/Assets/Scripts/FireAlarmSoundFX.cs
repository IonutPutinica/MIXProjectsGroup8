using UnityEngine;

public class FireAlarmSoundFX : MonoBehaviour
{
    public AudioSource fireAlarm;

    public void FireAlarmStart()
    {
        fireAlarm.Play();
    }

    public void FireAlarmStop()
    {
        fireAlarm.Stop();
    }
}