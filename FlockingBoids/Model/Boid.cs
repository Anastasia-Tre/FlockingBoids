using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Boid
    {
        public Position Position;
        public Velocity Velocity;
        public float Speed;
        public bool IsEnemy = false;

        public Boid(float x, float y, float xVel, float yVel)
        {
            Position = new Position(x, y);
            Velocity = new Velocity(xVel, yVel);
        }
    }
}
