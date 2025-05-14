using UnityEngine;

using Controllers.Ball;

namespace Controllers
{
    // Controls the app workflow.
    public class BounceController : BounceElement
    {
        public BallController ball;

        private void Start()
        {
            ball = FindFirstObjectByType<BallController>();
        }

        public void OnGameComplete()
        {
            Debug.Log("Victory!!!");
        }
    }
}
