namespace Renderer
{
    public class Color
    {
        public readonly byte R, G, B, A;

        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            (R, G, B, A) = (red, green, blue, alpha);
        }
    }
}