using UnityEngine;

public class RTPCVolumeController : MonoBehaviour
{
    [Header("RTPC Names")]
    [SerializeField] private string masterVolumeRTPC = "MasterVolume";
    [SerializeField] private string musicVolumeRTPC = "MusicVolume";
    [SerializeField] private string effectsVolumeRTPC = "SFXVolume";

    [Header("Volume Levels")]
    [Range(0f, 100f)][SerializeField] private float masterVolume = 100f;
    [Range(0f, 100f)][SerializeField] private float musicVolume = 100f;
    [Range(0f, 100f)][SerializeField] private float effectsVolume = 100f;

    private float lastMasterVolume = -1f;
    private float lastMusicVolume = -1f;
    private float lastEffectsVolume = -1f;

    private void OnEnable()
    {
        ApplyAllRTPCs(); // Ensure values are applied when enabled
    }

    private void Update()
    {
        UpdateRTPC(ref masterVolume, ref lastMasterVolume, masterVolumeRTPC);
        UpdateRTPC(ref musicVolume, ref lastMusicVolume, musicVolumeRTPC);
        UpdateRTPC(ref effectsVolume, ref lastEffectsVolume, effectsVolumeRTPC);
    }

    private void UpdateRTPC(ref float currentValue, ref float lastValue, string rtpcName)
    {
        if (Mathf.Abs(currentValue - lastValue) > 0.01f)
        {
            AkSoundEngine.SetRTPCValue(rtpcName, currentValue);
            lastValue = currentValue;
        }
    }

    private void ApplyAllRTPCs()
    {
        AkSoundEngine.SetRTPCValue(masterVolumeRTPC, masterVolume);
        AkSoundEngine.SetRTPCValue(musicVolumeRTPC, musicVolume);
        AkSoundEngine.SetRTPCValue(effectsVolumeRTPC, effectsVolume);

        lastMasterVolume = masterVolume;
        lastMusicVolume = musicVolume;
        lastEffectsVolume = effectsVolume;
    }
}


