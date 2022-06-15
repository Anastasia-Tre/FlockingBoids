namespace Model.Behaviour
{
    internal class AlignBehaviour : Behaviour
    {
        private const float Weight = 0.05f;

        public AlignBehaviour(Boid[] boids) :
            base(boids)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            var neighborCount = 0;
            var resultVelocity = new Velocity();
            foreach (var boid in Boids)
                if (boid.Position.Distance(curBoid.Position) < Vision)
                {
                    resultVelocity += boid.Velocity;
                    neighborCount += 1;
                }

            resultVelocity /= neighborCount;
            curBoid.Velocity -= (curBoid.Velocity - resultVelocity) * Weight;
        }
    }
}
