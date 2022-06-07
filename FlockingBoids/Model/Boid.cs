using System.Collections.Generic;

namespace Model
{
    public class Boid
    {
        public bool IsEnemy = false;
        public Position Position;
        public float Speed;
        public Velocity Velocity;
        private readonly List<Behaviour> behaviours;

        public Boid(float x, float y, float xVel, float yVel)
        {
            Position = new Position(x, y);
            Velocity = new Velocity(xVel, yVel);
            behaviours = new List<Behaviour>();
        }

        public void AddBehaviour(Behaviour behaviour)
        {
            behaviours.Add(behaviour);
        }
        
    }
}