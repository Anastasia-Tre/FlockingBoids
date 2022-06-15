using Model;

namespace Tests
{
    public class FieldTest
    {
        [Fact]
        public void TestBoidNumber()
        {
            var size = 100;
            Assert.Throws<Exception>(() =>
            {
                var field = new Field(size, size, size, size + 1);
            });
        }
    }
}