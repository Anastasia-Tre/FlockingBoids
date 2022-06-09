using System;
using System.Threading.Tasks;
using Model.Behaviour;

namespace Model
{
    public class Field
    {
        private readonly float _width, _height;
        public readonly Boid[] Boids;

        public Field(float width, float height, int boidsCount, int enemyCount)
        {
            (_width, _height) = (width, height);

            if (enemyCount > boidsCount) throw new Exception("Number of enemies is bigger than number of boids");
            Boids = new Boid[boidsCount];
            GenerateRandomBoids(enemyCount);
        }

        private void GenerateRandomBoids(int enemyCount)
        {
            var rnd = new Random();
            for (var i = 0; i < Boids.GetLength(0); i++)
            {
                Boids[i] = new Boid(
                    (float)rnd.NextDouble() * _width,
                    (float)rnd.NextDouble() * _height,
                    (float)(rnd.NextDouble() - .5),
                    (float)(rnd.NextDouble() - .5))
                {
                    IsEnemy = enemyCount > i
                };
            }


            var flockBehaviour = new FlockBehaviour(Boids, 100, 0.005f); // get rid of magic number
            var alignBehaviour = new AlignBehaviour(Boids, 100, 0.03f);
            var avoidBehaviour = new AvoidBehaviour(Boids, 20, 0.05f);
            foreach (var boid in Boids)
            {
                boid.AddBehaviour(flockBehaviour); // make array
                boid.AddBehaviour(alignBehaviour);
                boid.AddBehaviour(avoidBehaviour);
            }
        }

        public void Advance(float stepSize = 1)
        {
            Parallel.ForEach(Boids, boid =>
                {
                    boid.Move(stepSize);
                }
            );

        }
    }
}