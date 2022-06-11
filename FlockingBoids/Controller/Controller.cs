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
                100, // to fix
                5 // to fix
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
    }
}
