using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Behaviour
{
    internal class AvoidEnemiesBehaviour : Behaviour
    {
        public AvoidEnemiesBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            throw new NotImplementedException();
        }
    }
}
