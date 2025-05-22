using UnityEngine;

public class RTPCVolumeController : MonoBehaviour
{
    [Header("RTPC Names")]
    public string masterVolumeRTPC = "MasterVolume"; // needs to match to WWise RTPC name
    public string musicVolumeRTPC = "MusicVolume";
    public string effectsVolumeRTPC = "SFXVolume";

    [Header("Volume Levels")]
    [Range(0f, 100f)]
    public float masterVolume = 100f;

    [Range(0f, 100f)]
    public float musicVolume = 100f;

    [Range(0f, 100f)]
    public float effectsVolume = 100f;

    private float lastMasterVolume;
    private float lastMusicVolume;
    private float lastEffectsVolume;

    void Update()
    {
        if (Mathf.Abs(masterVolume - lastMasterVolume) > 0.01f)
        {
            AkSoundEngine.SetRTPCValue(masterVolumeRTPC, masterVolume);
            lastMasterVolume = masterVolume;
        }

        if (Mathf.Abs(musicVolume - lastMusicVolume) > 0.01f)
        {
            AkSoundEngine.SetRTPCValue(musicVolumeRTPC, musicVolume);
            lastMusicVolume = musicVolume;
        }

        if (Mathf.Abs(effectsVolume - lastEffectsVolume) > 0.01f)
        {
            AkSoundEngine.SetRTPCValue(effectsVolumeRTPC, effectsVolume);
            lastEffectsVolume = effectsVolume;
        }
    }
}


