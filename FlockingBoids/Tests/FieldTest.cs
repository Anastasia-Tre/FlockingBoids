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
        public void TestExceptinFieldSize()
        {
            Assert.Throws<Exception>(() => {
                var field = new Field(0, 0, Size, Size);
            });
        }
    }
}