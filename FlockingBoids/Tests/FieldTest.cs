using Model;

namespace Tests
{
    public class FieldTest
    {
        private const int Size = 100;

        [Fact]
        public void TestBoidNumber()
        {
            Assert.Throws<Exception>(() =>
            {
                var field = new Field(Size, Size, Size, Size + 1);
            });
        }

        [Fact]
        public void TestFieldSize()
        {
            Assert.Throws<Exception>(() => {
                var field = new Field(0, 0, Size, Size + 1);
            });
        }
    }
}