namespace Model.Behaviour
{
    public abstract class Behaviour
    {
        public Boid[] Boids;
        public float Distance;
        public float Weight;

        protected Behaviour(Boid[] boids, float distance, float weight)
        {
            Boids = boids;
            Distance = distance;
            Weight = weight;
        }

        public abstract void CalcVelocity(Boid curBoid);
    }
}
