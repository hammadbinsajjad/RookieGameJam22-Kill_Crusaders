using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
        [SerializeField] private GameObject step_sounds_audio_source;
        [SerializeField] private GameObject level_complete_audio_source;

    // Update is called once per frame
    void Update()
    {
        if (PassFinishLine.level_finished) {
            step_sounds_audio_source.SetActive(false);
            level_complete_audio_source.SetActive(true);
        }        
    }
}
