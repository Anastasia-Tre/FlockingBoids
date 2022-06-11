using Model;
using Renderer;

namespace Controller
{
    public class Controler
    {
        public Field Field { get; private set; }
        public IRenderer Renderer { get; private set; }

        public void CreateField(float width, float height)
        {
            Field = new Field(
                width, // to fix
                height, // to fix
                2, // to fix
                1 // to fix
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
    }
}
