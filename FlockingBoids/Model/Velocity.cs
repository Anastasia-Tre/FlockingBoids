using System;

namespace Model
{
    public class Velocity
    {
        public float X, Y;

        public Velocity(float x, float y)
        {
            (X, Y) = (x, y);
        }

        public double GetAngle()
        {
            if (X == 0 && Y == 0)
                return 0;
            var angle = Math.Atan(Y / X) * 180 / Math.PI - 90;
            if (X < 0)
                angle += 180;
            return angle;
        }
    }
}
