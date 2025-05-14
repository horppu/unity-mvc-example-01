using Models.Ball;

namespace Models
{
    // Contains all data related to the app.
    public class BounceModel : BounceElement
    {
        public BallModel ball;
        
        // Data
        public int winCondition;

        private void Start()
        {
            ball = FindFirstObjectByType<BallModel>();
        }
    }
}
