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

        public float GetAngle()
        {
            if (X == 0 && Y == 0)
                return 0;
            var angle = (float)(Math.Atan(Y / X) * 180 / Math.PI - 90);
            if (X < 0)
                angle += 180;
            return angle;
        }

        public void SetSpeed(float speed)
        {
            if (X == 0 && Y == 0)
                return;

            var currentSpeed = (float)Math.Sqrt(X * X + Y * Y);

            var targetX = X / currentSpeed * speed;
            var targetY = Y / currentSpeed * speed;

            X = targetX;
            Y = targetY;
        }
    }
}