using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Behaviour;

namespace Model
{
    public class Field
    {
        private readonly float _width, _height;
        public readonly Boid[] Boids;
        public float Distance = 20;
        public float Vision = 100;
        public float WeightAlign = 1.0f;
        public float WeightAvoid = 1.0f;
        public float WeightFlock = 1.0f;

        public Field(float width, float height, int boidsCount, int enemyCount)
        {
            (_width, _height) = (width, height);

            if (enemyCount > boidsCount) throw new Exception("Number of enemies is bigger than number of boids");
            Boids = new Boid[boidsCount];
            GenerateRandomBoids(enemyCount);
        }

        private void GenerateRandomBoids(int enemyCount)
        {
            var behaviours = new List<Behaviour.Behaviour>
            {
                new FlockBehaviour(Boids, Vision, 0.0005f * WeightFlock),
                new AlignBehaviour(Boids, Vision, 0.05f * WeightAlign),
                new AvoidBoidsBehaviour(Boids, Distance, 0.005f * WeightAvoid),
                new AvoidEnemiesBehaviour(Boids, Vision, 0.005f * WeightAvoid),
                new AvoidWallsBehaviour(Boids, _width, _height, 1)
            };

            var rnd = new Random();
            for (var i = 0; i < Boids.GetLength(0); i++)
            {
                Boids[i] = new Boid(
                    (float)rnd.NextDouble() * _width,
                    (float)rnd.NextDouble() * _height,
                    (float)(rnd.NextDouble() - .5),
                    (float)(rnd.NextDouble() - .5),
                    (float)(1.5 + rnd.NextDouble()))
                {
                    IsEnemy = enemyCount > i
                };
                Boids[i].Speed = enemyCount > i ? Boids[i].Speed - 0.5f : Boids[i].Speed;
                behaviours.ForEach(behaviour => Boids[i].AddBehaviour(behaviour));
            }
        }

        public void Advance(float stepSize = 1)
        {
            Parallel.ForEach(Boids, boid => boid.Move(stepSize));
        }
    }
}