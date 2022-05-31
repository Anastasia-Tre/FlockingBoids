using SkiaSharp;
using Model;

namespace Renderer
{
    public class RendererSkiaSharp : IRenderer
    {
        private readonly SKCanvas _canvas;
        private readonly SKPaint _paint;
        private readonly Color _backgroundColor = new(0, 0, 50);
        private readonly Color _boidColor = new(250, 100, 250);
        private const float BoidRadius = 4f;

        public RendererSkiaSharp(SKCanvas canvas)
        {
            _canvas = canvas;
            _paint = new SKPaint
            {
                IsAntialias = true
            };
        }

        public void Render(Field field)
        {
            Clear(_backgroundColor);
            foreach (var boid in field.Boids)
            {
                DrawBoid(boid, _boidColor);
            }

        }

        public void DrawBoid(Boid boid, Color color)
        {
            FillCircle(new Point(boid.Position.X, boid.Position.Y), BoidRadius, color);
        }

        public void Clear(Color color)
        {
            _canvas.Clear(ConvertColor(color));
        }

        public void Dispose()
        {
            _paint.Dispose();
        }

        public void DrawLine(Point pt1, Point pt2, float lineWidth, Color color)
        {
            _paint.Color = ConvertColor(color);
            _canvas.DrawLine(ConvertPoint(pt1), ConvertPoint(pt2), _paint);
        }

        public void FillCircle(Point center, float radius, Color color)
        {
            _paint.Color = ConvertColor(color);
            _canvas.DrawCircle(ConvertPoint(center), radius, _paint);
        }

        private SKColor ConvertColor(Color color)
        {
            return new SKColor(color.R, color.G, color.B, color.A);
        }

        private SKPoint ConvertPoint(Point pt)
        {
            return new SKPoint((float)pt.X, (float)pt.Y);
        }
    }
}