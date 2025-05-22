using UnityEngine;

namespace Controllers.Ball
{
    public class BallController : BounceElement
    {
        // luodaan bounceEvent
        public AK.Wwise.Event bounceEvent;
        public AK.Wwise.Event victoryEvent;
        public AK.Wwise.Event dynamicEvent;

        // Handles the ball hit event
        public void OnGroundHit()
        {
            // post bounceEvent (choose event on inspector). snippet: This code checks if the symbol DISABLE_WWISE is not defined
            #if !DISABLE_WWISE
            bounceEvent.Post(gameObject);
            #endif


            App.model.ball.bounces++;
            Debug.Log("Bounce " + App.model.ball.bounces);

            if (App.model.ball.bounces >= App.model.winCondition)
            {
                #if !DISABLE_WWISE
                victoryEvent.Post(gameObject);
                #endif

                #if !DISABLE_WWISE
                dynamicEvent.Post(gameObject);
                #endif

                App.view.ball.enabled = false;
                App.view.ball.GetComponent<Rigidbody>().isKinematic = true;
                App.controller.OnGameComplete();
            }
            else
            {
                App.view.ball.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
            }
        }
       
    }
}
