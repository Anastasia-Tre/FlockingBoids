using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Behaviour;

namespace Model
{
    public class Field
    {
        private float _width = 1200f, _height = 600f;
        public readonly Boid[] Boids;

        public Field(float width, float height, int boidsCount, int enemyCount)
        {
            if (enemyCount > boidsCount)
                throw new Exception(
                    "Number of enemies is bigger than number of boids");
            Boids = new Boid[boidsCount];
            GenerateRandomBoids(enemyCount);
        }

        public void SetFieldSize(float width, float height)
        {
            if (width <= 0 || height <= 0)
                throw new Exception(
                    "Wrong size of field");
            (_width, _height) = (width, height);
        }

        private void GenerateRandomBoids(int enemyCount)
        {
            var behaviours = new List<Behaviour.Behaviour>
            {
                new FlockBehaviour(Boids),
                new AlignBehaviour(Boids),
                new AvoidBoidsBehaviour(Boids),
                new AvoidEnemiesBehaviour(Boids),
                new AvoidWallsBehaviour(Boids, _width, _height)
            };

            var rnd = new Random();
            for (var i = 0; i < Boids.GetLength(0); i++)
            {
                Boids[i] = new Boid(
                    (float)rnd.NextDouble() * _width,
                    (float)rnd.NextDouble() * _height,
                    (float)(rnd.NextDouble() - .5),
                    (float)(rnd.NextDouble() - .5),
                    (float)(1 + rnd.NextDouble()));
                if (i < enemyCount)
                {
                    Boids[i].IsEnemy = true;
                    Boids[i].Speed += .5f;
                }

                behaviours.ForEach(
                    behaviour => Boids[i].AddBehaviour(behaviour));
            }
        }

        public void Advance(float stepSize = 1)
        {
            Parallel.ForEach(Boids, boid => boid.Move(stepSize));
        }
    }
}
