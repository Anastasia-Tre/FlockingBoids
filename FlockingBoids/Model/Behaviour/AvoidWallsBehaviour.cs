using System;

namespace Model.Behaviour
{
    internal class AvoidWallsBehaviour : Behaviour
    {
        private const float Pad = 100;
        private const float Turn = 0.1f;

        public AvoidWallsBehaviour(Boid[] boids, float width, float height, float weight) 
            : base(boids, Pad, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            throw new NotImplementedException();
        }
    }
}
