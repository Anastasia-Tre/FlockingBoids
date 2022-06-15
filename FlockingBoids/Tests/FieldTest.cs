using Model;

namespace Tests
{
    public class FieldTest
    {
        private const int Size = 100;

        [Fact]
        public void TestExceptionBoidNumber()
        {
            Assert.Throws<Exception>(() =>
            {
                var field = new Field(Size, Size, Size, Size + 1);
            });
        }

        [Fact]
        public void TestBoidNumber()
        {
            var field = new Field(Size, Size, Size, Size);
            var counter = field.Boids.Count(boid => boid.IsEnemy);
            Assert.Equal(counter, Size);
        }

        [Fact]
        public void TestExceptionFieldSize()
        {
            Assert.Throws<Exception>(() => {
                var field = new Field(0, 0, Size, Size);
            });
        }
    }
}