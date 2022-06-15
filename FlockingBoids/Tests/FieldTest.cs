using Model;

namespace Tests;

public class FieldTest
{
    private const int Size = 100;
    private Field? _field;

    [Fact]
    public void TestExceptionBoidNumber()
    {
        Assert.Throws<Exception>(() =>
        {
            _field = new Field(Size, Size, Size, Size + 1);
        });
    }

    [Fact]
    public void TestBoidNumber()
    {
        _field = new Field(Size, Size, Size, Size);
        var counter = _field.Boids.Count(boid => boid.IsEnemy);
        Assert.Equal(counter, Size);
    }

    [Fact]
    public void TestExceptionFieldSize()
    {
        Assert.Throws<Exception>(() =>
        {
            _field = new Field(0, 0, Size, Size);
        });
    }
}
