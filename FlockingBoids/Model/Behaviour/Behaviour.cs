namespace Model.Behaviour
{
    public abstract class Behaviour
    {
        public Boid[] Boids;
        public const float Distance = 20;
        public const float Vision = 100;

        protected Behaviour(Boid[] boids)
        {
            Boids = boids;
        }

        public abstract void CalcVelocity(Boid curBoid);
    }
}
