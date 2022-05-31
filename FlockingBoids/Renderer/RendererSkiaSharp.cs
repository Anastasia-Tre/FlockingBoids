using SkiaSharp;
using Model;

namespace Renderer
{
    public class RendererSkiaSharp : IRenderer
    {
        private readonly SKCanvas _canvas;
        private readonly SKPaint _paint;
        private readonly Color backgroundColor = new Color(0, 100, 50);
        private readonly Color boidColor = new Color(250, 100, 50);
        private readonly float boidRadius = 4f;

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
            Clear(backgroundColor);
            foreach (var boid in field.Boids)
            {
                DrawBoid(boid, boidColor);
            }

        }

        public void DrawBoid(Boid boid, Color color)
        {
            FillCircle(new Point(boid.Position.X, boid.Position.Y), boidRadius, color);
        }

        public void Clear(Color color)
        {
            _canvas.Clear(ConvertColor(color));
        }

        public void Dispose()
        {
            _paint.Dispose();
        }

        public void DrawLine(Point pt1, Point pt2, double lineWidth, Color color)
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