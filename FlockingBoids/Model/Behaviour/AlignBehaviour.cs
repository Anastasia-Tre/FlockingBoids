namespace Model.Behaviour
{
    internal class AlignBehaviour : Behaviour
    {
        public AlignBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            // determine mean velocity of the flock
            int neighborCount = 0;
            Velocity meanVelocity = new Velocity(0, 0);
            foreach (Boid boid in Boids)
            {
                if (boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    meanVelocity += boid.Velocity;
                    neighborCount += 1;
                }
            }
            meanVelocity /= neighborCount;

            //Vel.X -= (Vel.X - meanVelX) * weight;
            //Vel.Y -= (Vel.Y - meanVelY) * weight;

            return meanVelocity;
        }
    }
}
