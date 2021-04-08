using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// WwiseEventPlayer class handles the activation of any Wwise Event Object.
/// </summary>
public class WwiseEventPlayer : MonoBehaviour
{
    public static WwiseEventPlayer instance;

    /// <summary>
    /// Function used to activate an event in Wwise.
    /// </summary>
    /// <param name="eventPath"></param>
    public void PlayeWwiseEvent(string eventPath)
    {
        AkSoundEngine.PostEvent(eventPath, gameObject);
    }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
