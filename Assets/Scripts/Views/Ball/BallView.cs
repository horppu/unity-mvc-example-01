namespace Views.Ball
{
    // Describes the Ball view and its features.
    public class BallView : BounceElement
    {
        // Only this is necessary. Physics is doing the rest of work.
        // Callback called upon collision.
        private void OnCollisionEnter()
        {
            App.controller.ball.OnGroundHit();
        }
    }
}