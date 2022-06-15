namespace Model.Behaviour
{
    internal class AvoidBoidsBehaviour : Behaviour
    {
        public AvoidBoidsBehaviour(Boid[] boids, float weight)
            : base(boids, weight)
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
