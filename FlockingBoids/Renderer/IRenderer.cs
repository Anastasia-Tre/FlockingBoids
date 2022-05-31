using System;

namespace Renderer
{
    public interface IRenderer : IDisposable
    {
        void Clear(Color color);
        void DrawLine(Point pt1, Point pt2, float lineWidth, Color color);
        void FillCircle(Point center, float radius, Color color);
    }
}