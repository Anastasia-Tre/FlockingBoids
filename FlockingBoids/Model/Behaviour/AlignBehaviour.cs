namespace Model.Behaviour
{
    internal class AlignBehaviour : Behaviour
    {
        public AlignBehaviour(Boid[] boids, float distance, float weight) :
            base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            var neighborCount = 0;
            var resultVelocity = new Velocity();
            foreach (var boid in Boids)
                if (boid.Position.Distance(curBoid.Position) < Distance)
                {
                    resultVelocity += boid.Velocity;
                    neighborCount += 1;
                }

            resultVelocity /= neighborCount;
            curBoid.Velocity -= (curBoid.Velocity - resultVelocity) * Weight;
        }
    }
}
