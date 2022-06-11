namespace Model.Behaviour
{
    internal class AlignBehaviour : Behaviour
    {
        public AlignBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            var neighborCount = 0;
            var resultVelocity = new Velocity(0, 0);
            foreach (var boid in Boids)
            {
                if (boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    resultVelocity += boid.Velocity;
                    neighborCount += 1;
                }
            }
            resultVelocity /= neighborCount;
            currentBoid.Velocity -= (currentBoid.Velocity - resultVelocity) * Weight;
        }
    }
}
