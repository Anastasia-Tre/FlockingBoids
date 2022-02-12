using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Position
    {
        public float X, Y;

        public Position(float x, float y)
        {
            (X, Y) = (x, y);
        }

        public void Move(Velocity velocity, float step)
        {
            X += velocity.X * step;
            Y += velocity.Y * step;
        }


    }
}
