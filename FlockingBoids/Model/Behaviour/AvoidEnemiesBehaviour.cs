namespace Model.Behaviour
{
    internal class AvoidEnemiesBehaviour : Behaviour
    {
        private const float Weight = 0.005f;

        public AvoidEnemiesBehaviour(Boid[] boids)
            : base(boids)
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
