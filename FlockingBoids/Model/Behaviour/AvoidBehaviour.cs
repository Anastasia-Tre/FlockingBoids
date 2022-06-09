namespace Model.Behaviour
{
    internal class AvoidBehaviour : Behaviour
    {
        public AvoidBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override Velocity GetVelocity(Boid currentBoid)
        {
            var resultVelocity = new Velocity(0, 0);
            for (int i = 0; i < Boids.Length; i++) // rewrite to foreach
            {
                Boid boid = Boids[i];
                if (boid.IsEnemy && boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    if (boid.Position.Distance(currentBoid.Position) < Distance)
                    {
                        //Vel.X -= (boid.Pos.X - Pos.X) * weight;
                        //Vel.Y -= (boid.Pos.Y - Pos.Y) * weight;

                        //currentBoid.Velocity -= (boid.Position - currentBoid.Position) * Weight;
                        //resultVelocity = (boid.Position - currentBoid.Position) * Weight * -1;
                    }
                }
            }

            return resultVelocity;
        }
    }
}
