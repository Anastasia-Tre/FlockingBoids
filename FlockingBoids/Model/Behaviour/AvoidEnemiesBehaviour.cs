namespace Model.Behaviour
{
    internal class AvoidEnemiesBehaviour : Behaviour
    {
        public AvoidEnemiesBehaviour(Boid[] boids, float weight)
            : base(boids, weight)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            foreach (var boid in Boids)
                if (boid.IsEnemy &&
                    boid.Position.Distance(curBoid.Position) < Vision)
                    curBoid.Velocity -=
                        (boid.Position - curBoid.Position) * Weight;
        }
    }
}
