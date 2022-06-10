﻿namespace Model.Behaviour
{
    internal class AvoidWallsBehaviour : Behaviour
    {
        private const float Pad = 100;
        private const float Turn = 0.1f;

        private readonly float _width;
        private readonly float _height;

        public AvoidWallsBehaviour(Boid[] boids, float width, float height, float weight) : base(boids, Pad, weight)
        {
            _width = width;
            _height = height;
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            var resultVelocity = new Velocity(0, 0);

            if (currentBoid.Position.X < Pad) resultVelocity.X += Turn;
            if (currentBoid.Position.Y < Pad) resultVelocity.Y += Turn;
            if (currentBoid.Position.X > _width - Pad) resultVelocity.X -= Turn;
            if (currentBoid.Position.Y > _height - Pad) resultVelocity.Y -= Turn;

            return resultVelocity * Weight;
        }
    }
}
