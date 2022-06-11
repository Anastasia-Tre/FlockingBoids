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

        public (float x, float y) Delta(Position otherPosition)
        {
            return (otherPosition.X - X, otherPosition.Y - Y);
        }

        public float Distance(Position otherPosition)
        {
            var (dX, dY) = Delta(otherPosition);
            return (float)Math.Sqrt(dX * dX + dY * dY);
        }

        public static Position operator +(Position pos1, Position pos2)
        {
            return new Position(pos1.X + pos2.X, pos1.Y + pos2.Y);
        }

        public static Position operator -(Position pos1, Position pos2)
        {
            return new Position(pos1.X - pos2.X, pos1.Y - pos2.Y);
        }

        public static Position operator *(Position pos, float num)
        {
            return new Position(pos.X * num, pos.Y * num);
        }

        public static Position operator /(Position pos, float num)
        {
            return new Position(pos.X / num, pos.Y / num);
        }

    }
}