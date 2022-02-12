using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Field
    {
        readonly float Width, Height;
        public readonly Boid[] Boids;

        public Field(float width, float height, int boidsCount, int enemyCount)
        {
            (Width, Height) = (width, height);

            if (enemyCount > boidsCount)
            {
                throw new Exception("Number of enemies is bigger than number of boids");
            }
            Boids = new Boid[boidsCount];
            GenerateRandomBoids(enemyCount);
        }

        private void GenerateRandomBoids(int enemyCount)
        {
            Random rnd = new Random();
            for (int i = 0; i < Boids.GetLength(0); i++)
            {
                Boids[i] = new Boid(
                    x: (float)rnd.NextDouble() * Width,
                    y: (float)rnd.NextDouble() * Height,
                    xVel: (float)(rnd.NextDouble() - .5),
                    yVel: (float)(rnd.NextDouble() - .5));

                Boids[i].IsEnemy = enemyCount < i;
            }
        }

    }
}
