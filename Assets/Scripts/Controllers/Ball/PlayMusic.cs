using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AK.Wwise.Event playMusic;

    void Start()
    {
        // post playMusic Event (choose event on inspector). snippet: This code checks if the symbol DISABLE_WWISE is not defined
#if !DISABLE_WWISE
        playMusic.Post(gameObject);
#endif
    }

       
}
