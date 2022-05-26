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

        public (double x, double y) Delta(Position otherPosition)
        {
            return (otherPosition.X - X, otherPosition.Y - Y);
        }

        public double Distance(Position otherPosition)
        {
            var (dX, dY) = Delta(otherPosition);
            return Math.Sqrt(dX * dX + dY * dY);
        }

    }
}
