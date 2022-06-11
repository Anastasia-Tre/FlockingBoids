namespace Model.Behaviour
{
    internal class AvoidBoidsBehaviour : Behaviour
    {
        public AvoidBoidsBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            foreach (var boid in Boids)
            {
                if (boid.IsEnemy == currentBoid.IsEnemy) 
                {
                    float closeness = Distance - boid.Position.Distance(currentBoid.Position);
                    if (closeness > 0)
                    {
                        currentBoid.Velocity -= (boid.Position - currentBoid.Position) * Weight * closeness;
                    }
                }
            }
        }
    }
}
