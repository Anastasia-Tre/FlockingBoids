using Model;
using Renderer;

namespace Controller
{
    public class Controller
    {
        public Field Field { get; private set; }
        public IRenderer Renderer { get; private set; }

        public void CreateField(float width, float height)
        {
            Field = new Field(
                width: width, // to fix
                height: height, // to fix
                boidsCount: 100, // to fix
                enemyCount: 10 // to fix
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }


    }
}
