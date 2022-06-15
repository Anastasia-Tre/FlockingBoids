namespace Model.Behaviour
{
    internal class AvoidBoidsBehaviour : Behaviour
    {
        public const float Weight = 0.005f;

        public AvoidBoidsBehaviour(Boid[] boids)
            : base(boids)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            foreach (var boid in Boids)
            {
                var closeness =
                    Distance - boid.Position.Distance(curBoid.Position);
                if (closeness > 0)
                    curBoid.Velocity -= (boid.Position - curBoid.Position) *
                                        Weight * closeness;
            }
        }
    }
}
