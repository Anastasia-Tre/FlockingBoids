namespace Model.Behaviour
{
    public abstract class Behaviour
    {
        public const float Distance = 20;
        public const float Vision = 100;
        public Boid[] Boids;

        protected Behaviour(Boid[] boids)
        {
            Boids = boids;
        }

        public abstract void CalcVelocity(Boid curBoid);
    }
}
