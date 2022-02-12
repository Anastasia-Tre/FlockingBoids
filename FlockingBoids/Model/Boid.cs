using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Boid
    {
        public float X, Y;
        public float Velocity;

        public Boid(float x, float y)
        {
            (X, Y) = (x, y);
        }
    }
}
