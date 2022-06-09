using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Behaviour
{
    internal class AvoidBehaviour : Behaviour
    {
        public AvoidBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            var resultVelocity = new Velocity(0, 0);
            for (int i = 0; i < Boids.Length; i++)
            {
                Boid boid = Boids[i];
                if (boid.IsEnemy && boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    if (boid.Position.Distance(currentBoid.Position) < Distance)
                    {
                        // steer away regardless of distance
                        //Vel.X -= (boid.Pos.X - Pos.X) * weight;
                        //Vel.Y -= (boid.Pos.Y - Pos.Y) * weight;
                        //currentBoid.Velocity -= (boid.Position - currentBoid.Position) * Weight;
                    }
                }
            }

            return resultVelocity;
        }
    }
}
