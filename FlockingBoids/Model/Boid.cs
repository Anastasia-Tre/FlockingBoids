using System.Collections.Generic;

namespace Model
{
    public class Boid
    {
        public bool IsEnemy = false;
        public Position Position;
        public float Speed;
        public Velocity Velocity;
        private readonly List<Behaviour.Behaviour> _behaviours;

        public Boid(float x, float y, float xVel, float yVel)
        {
            Position = new Position(x, y);
            Velocity = new Velocity(xVel, yVel);
            _behaviours = new List<Behaviour.Behaviour>();
        }

        public void AddBehaviour(Behaviour.Behaviour behaviour)
        {
            _behaviours.Add(behaviour);
        }

        public void Move()
        {
            // Velocity totalVelocity;
            //foreach (var behaviour in _behaviours)
            {
                
            }
        }
    }
}