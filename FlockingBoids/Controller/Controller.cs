using Model;
using Renderer;

namespace Controller
{
    public class Controller
    {
        public Field Field { get; private set; }
        public IRenderer Renderer { get; private set; }

        public void CreateField()
        {
            Field = new Field(
                500, // to fix
                5 // to fix
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
    }
}
