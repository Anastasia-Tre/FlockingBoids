using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class FlockBehaviour : Behaviour
    {
        public FlockBehaviour(Boid[] boids, float distance, float weight) : 
            base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            if (currentBoid.IsEnemy)
                Distance *= 2;

            int neighborCount = 0;
            float centerX = 0;
            float centerY = 0;
            foreach (Boid boid in Boids)
            {
                if (boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    centerX += boid.Position.X;
                    centerY += boid.Position.Y;
                    neighborCount += 1;
                }
            }
            centerX /= neighborCount;
            centerY /= neighborCount;

            // steer toward the flock
            var X = (centerX - currentBoid.Position.X) * Weight;
            var Y = (centerY - currentBoid.Position.Y) * Weight;

            var resultVelocity = new Velocity(X, Y);
            return resultVelocity;
        }
    }
}
