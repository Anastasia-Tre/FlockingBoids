using System.Collections.Generic;

namespace Model
{
    public class Boid
    {
        private readonly List<Behaviour.Behaviour> _behaviours;
        public bool IsEnemy = false;
        public Position Position;
        public float Speed;
        public Velocity Velocity;

        public Boid(float x, float y, float xVel, float yVel, float speed)
        {
            Position = new Position(x, y);
            Velocity = new Velocity(xVel, yVel);
            Speed = speed;
            _behaviours = new List<Behaviour.Behaviour>();
        }

        public void AddBehaviour(Behaviour.Behaviour behaviour)
        {
            _behaviours.Add(behaviour);
        }

        public void Move(float stepSize)
        {
            _behaviours.ForEach(behaviour => behaviour.CalcVelocity(this));
            Velocity.SetSpeed(Speed);
            Position.Move(Velocity, stepSize);
        }
    }
}
