using System;

namespace Model.Behaviour
{
    internal class AvoidWallsBehaviour : Behaviour
    {
        public AvoidWallsBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            throw new NotImplementedException();
        }
    }
}
