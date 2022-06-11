namespace Model.Behaviour
{
    internal class AvoidEnemiesBehaviour : Behaviour
    {
        public AvoidEnemiesBehaviour(Boid[] boids, float distance, float weight)
            : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            foreach (var boid in Boids)
                if (boid.IsEnemy &&
                    boid.Position.Distance(curBoid.Position) < Distance)
                    curBoid.Velocity -=
                        (boid.Position - curBoid.Position) * Weight;
        }
    }
}
