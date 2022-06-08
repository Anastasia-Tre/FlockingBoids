namespace Model.Behaviour
{
    internal class FlockBehaviour : Behaviour
    {
        public FlockBehaviour(Boid[] boids, float distance, float weight) :
            base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            if (currentBoid.IsEnemy)
                Distance *= 2;

            var neighborCount = 0;
            float centerX = 0;
            float centerY = 0;
            foreach (var boid in Boids)
                if (boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    centerX += boid.Position.X;
                    centerY += boid.Position.Y;
                    neighborCount += 1;
                }

            centerX /= neighborCount;
            centerY /= neighborCount;

            var x = (centerX - currentBoid.Position.X) * Weight;
            var y = (centerY - currentBoid.Position.Y) * Weight;

            var resultVelocity = new Velocity(x, y);
            return resultVelocity;
        }
    }
}