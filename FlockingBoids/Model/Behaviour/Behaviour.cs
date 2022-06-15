namespace Model.Behaviour
{
    public abstract class Behaviour
    {
        public Boid[] Boids;
        public float Weight;
        public const float Distance = 20;
        public const float Vision = 100;

        protected Behaviour(Boid[] boids, float weight)
        {
            Boids = boids;
            Weight = weight;
        }

        public abstract void CalcVelocity(Boid curBoid);
    }
}
