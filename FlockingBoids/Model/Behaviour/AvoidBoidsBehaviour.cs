namespace Model.Behaviour
{
    internal class AvoidBoidsBehaviour : Behaviour
    {
        public AvoidBoidsBehaviour(Boid[] boids, float distance, float weight) : base(boids, distance, weight)
        {
        }

        public override void CalcVelocity(Boid currentBoid)
        {
            var resultVelocity = new Velocity(0, 0);
            for (int i = 0; i < Boids.Length; i++) // rewrite to foreach
            {
                Boid boid = Boids[i];
                /*if (boid.IsEnemy && boid.Position.Distance(currentBoid.Position) < Distance)
                {
                    if (boid.Position.Distance(currentBoid.Position) < Distance)
                    {
                        //Vel.X -= (boid.Pos.X - Pos.X) * weight;
                        //Vel.Y -= (boid.Pos.Y - Pos.Y) * weight;

                        //currentBoid.Velocity -= (boid.Position - currentBoid.Position) * Weight;
                        resultVelocity = (boid.Position - currentBoid.Position);
                    }
                }*/
                float closeness = 1;
                if (boid.IsEnemy != currentBoid.IsEnemy)
                {
                    closeness *= 2;

                }
                closeness *= Distance - boid.Position.Distance(currentBoid.Position);
                if (closeness > 1)
                {
                    // avoid with a magnitude correlated to closeness
                    //Vel.X -= (boid.Pos.X - Pos.X) * weight * closeness;
                    //Vel.Y -= (boid.Pos.Y - Pos.Y) * weight * closeness;
                    resultVelocity = (boid.Position - currentBoid.Position);
                }

            }
            currentBoid.Velocity -= resultVelocity * Weight;
        }
    }
}
