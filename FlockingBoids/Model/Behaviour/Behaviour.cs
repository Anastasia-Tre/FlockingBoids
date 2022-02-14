using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Behaviour
{
    public abstract class Behaviour
    {
        public float Weight;
        public float Distance;
        public Boid[] Boids;

        public Behaviour(Boid[] boids, float distance, float weight)
        {
            Boids = boids;
            Distance = distance;
            Weight = weight;
        }

        public abstract Velocity GetVelocity(Boid currentBoid);
    }
}
