namespace Model.Behaviour
{
    internal class AvoidEnemiesBehaviour : Behaviour
    {
        public AvoidEnemiesBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            foreach (var boid in Boids)
            {
                if (boid.IsEnemy && boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    if (boid.Position.Distance(currentBoid.Position) < Distance)
                    {
                        currentBoid.Velocity -= (boid.Position - currentBoid.Position) * Weight;
                    }
                }
            }
        }
    }
}
