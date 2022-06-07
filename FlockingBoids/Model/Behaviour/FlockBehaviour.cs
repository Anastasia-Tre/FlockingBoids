using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Behaviour
{
    internal class FlockBehaviour : Behaviour
    {
        public FlockBehaviour(Boid[] boids, float distance, float weight) : 
            base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            throw new NotImplementedException();
        }
    }
}
