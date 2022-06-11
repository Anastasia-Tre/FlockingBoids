namespace Model.Behaviour
{
    internal class AvoidWallsBehaviour : Behaviour
    {
        private const float Pad = 100;
        private const float Turn = 0.1f;
        private readonly float _height;
        private readonly float _width;

        public AvoidWallsBehaviour(Boid[] boids, float width, float height, float weight)
            : base(boids, Pad, weight)
        {
            _width = width;
            _height = height;
        }

        public override void CalcVelocity(Boid curBoid)
        {
            var resultVelocity = new Velocity(0, 0);

            if (curBoid.Position.X < Pad) resultVelocity.X += Turn;
            if (curBoid.Position.Y < Pad) resultVelocity.Y += Turn;
            if (curBoid.Position.X > _width - Pad)
                resultVelocity.X -= Turn;
            if (curBoid.Position.Y > _height - Pad)
                resultVelocity.Y -= Turn;

            curBoid.Velocity += resultVelocity * Weight;
        }
    }
}
