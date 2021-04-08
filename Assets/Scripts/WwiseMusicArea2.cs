using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseMusicArea2 : MonoBehaviour
{
    private void StartMusic()
    {
        WwiseEventPlayer.instance.PlayeWwiseEvent(WwiseEventConstants.MUSIC_AREA_2_START);
    }

    private void StopMusic()
    {
        WwiseEventPlayer.instance.PlayeWwiseEvent(WwiseEventConstants.MUSIC_AREA_2_STOP);
    }

    void Start()
    {
        StartMusic();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopMusic();
        }
    }
}
