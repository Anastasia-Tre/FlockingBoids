﻿namespace Model.Behaviour
{
    internal class FlockBehaviour : Behaviour
    {
        public FlockBehaviour(Boid[] boids, float distance, float weight) :
            base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            Distance = currentBoid.IsEnemy ? 2 * Distance : Distance;
            var neighborCount = 0;
            var resultVelocity = new Velocity(0, 0);

            foreach (var boid in Boids)
                if (boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    resultVelocity += boid.Position;
                    neighborCount += 1;
                }

            resultVelocity = resultVelocity / neighborCount - currentBoid.Position;
            currentBoid.Velocity += resultVelocity * Weight;
        }
    }
}