using System;

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

        public void Shift(Position position)
        {
            X += position.X;
            Y += position.Y;
        }




    }
}
