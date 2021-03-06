using Model;
using SkiaSharp;

namespace Renderer
{
    public class RendererSkiaSharp : IRenderer
    {
        private const float BoidRadius = 4f;
        private readonly Color _backgroundColor = new(0, 0, 50);
        private readonly Color _boidColor = new(250, 250, 227);
        private readonly SKCanvas _canvas;
        private readonly Color _enemyColor = new(247, 175, 49);
        private readonly SKPaint _paint;

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
                if (boid.IsEnemy) DrawTailBoid(boid, _enemyColor);
                else DrawTailBoid(boid, _boidColor);
        }

        public void DrawBoid(Boid boid, Color color)
        {
            FillCircle(new Point(boid.Position.X, boid.Position.Y), BoidRadius,
                color);
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

        public void DrawTailBoid(Boid boid, Color color)
        {
            for (var i = 0; i < boid.Positions.Count; i++)
            {
                var frac = (i + 1f) / boid.Positions.Count;
                var alpha = (byte)(255 * frac * .5);
                FillCircle(new Point(boid.Positions[i].X, boid.Positions[i].Y),
                    BoidRadius / 2.5f,
                    new Color(color.R, color.G, color.B, alpha));
            }

            FillCircle(new Point(boid.Position.X, boid.Position.Y), BoidRadius,
                color);
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
