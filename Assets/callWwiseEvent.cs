using UnityEngine;

public class PlayWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event bounceEvent;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            bounceEvent.Post(gameObject);
        }
    }
}

