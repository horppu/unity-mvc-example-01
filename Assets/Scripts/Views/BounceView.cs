using Views.Ball;

namespace Views
{
    // Contains all views related to the app.
    public class BounceView : BounceElement
    {
        // Reference to the ball.
        public BallView ball;

        private void Start()
        {
            ball = FindFirstObjectByType<BallView>();
        }
    }
}
