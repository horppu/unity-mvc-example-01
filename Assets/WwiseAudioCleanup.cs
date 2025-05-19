using UnityEngine;

public class WwiseAudioCleanup : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        CleanupWwiseAudio();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            CleanupWwiseAudio();
        }
    }

    private void CleanupWwiseAudio()
    {
        AkSoundEngine.StopAll();
        Debug.Log("Wwise audio cleanup performed: All sounds stopped.");
    }
}
