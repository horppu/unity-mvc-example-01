
using UnityEngine;

public class WwiseIdleAudioWatchdog : MonoBehaviour
{
    private float idleTimer = 0f;
    private const float idleTimeout = 30f;
    private bool isIdle = false;

    void Update()
    {
        // Check for player input or game state changes
        if (Input.anyKey || !IsGameIdle())
        {
            idleTimer = 0f;
            isIdle = false;
        }
        else
        {
            idleTimer += Time.deltaTime;
            if (idleTimer >= idleTimeout && !isIdle)
            {
                isIdle = true;
                StopAllWwiseAudio();
            }
        }
    }

    private bool IsGameIdle()
    {
        // Implement your game-specific logic to determine if the game is idle
        // For example, check if the game is in a "game over" state or no active gameplay
        return true; // Placeholder, replace with actual game state check
    }

    private void StopAllWwiseAudio()
    {
        AkSoundEngine.StopAll();
        Debug.Log("All Wwise audio stopped due to idle timeout.");
    }
}
