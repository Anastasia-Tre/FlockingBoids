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
                    (float)(rnd.NextDouble() - .5),
                    (float)(.5 + rnd.NextDouble()))
                {
                    IsEnemy = enemyCount > i
                };
                if (enemyCount > i)
                {
                    Boids[i].Speed -= 0.5f;
                }
            }

            var behaviours = new Behaviour.Behaviour[]
            {
                new FlockBehaviour(Boids, 100, 0.001f), // remove magic numbers
                new AlignBehaviour(Boids, 100, 0.06f),
                new AvoidBoidsBehaviour(Boids, 20, 0.05f),
                new AvoidWallsBehaviour(Boids, _width, _height, 1)
            };

            foreach (var boid in Boids)
            {
                foreach (var behaviour in behaviours)
                {
                    boid.AddBehaviour(behaviour);
                }
            }
        }

        public void Advance(float stepSize = 1)
        {
            Parallel.ForEach(Boids, boid =>
                {
                    boid.Move(stepSize);
                }
            );

            /*foreach (var boid in Boids)
            {
                boid.Move(stepSize);
            }*/
        }
    }
}