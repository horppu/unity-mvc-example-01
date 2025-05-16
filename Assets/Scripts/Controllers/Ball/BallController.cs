using UnityEngine;

namespace Controllers.Ball
{
    public class BallController : BounceElement
    {
        // luodaan bounceEvent
        public AK.Wwise.Event bounceEvent;

        // Handles the ball hit event
        public void OnGroundHit()
        {
            // post bounceEvent (choose event on inspector)
            bounceEvent.Post(gameObject);

            App.model.ball.bounces++;
            Debug.Log("Bounce " + App.model.ball.bounces);

            if (App.model.ball.bounces >= App.model.winCondition)
            {
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
