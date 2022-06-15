namespace Model.Behaviour
{
    internal class FlockBehaviour : Behaviour
    {
        public FlockBehaviour(Boid[] boids, float weight) :
            base(boids, weight)
        {
        }

        public override void CalcVelocity(Boid curBoid)
        {
            var vision = curBoid.IsEnemy ? 2 * Vision : Vision;
            var neighborCount = 0;
            var resultVelocity = new Velocity();

            foreach (var boid in Boids)
                if (boid.Position.Distance(curBoid.Position) < vision)
                {
                    resultVelocity += boid.Position;
                    neighborCount += 1;
                }

            resultVelocity = resultVelocity / neighborCount - curBoid.Position;
            curBoid.Velocity += resultVelocity * Weight;
        }
    }
}
