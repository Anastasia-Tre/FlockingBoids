using Model;
using Renderer;

namespace Controller
{
    public class Controller
    {
        private const int BoidsCount = 400;
        private const int EnemyCount = 3;
        public Field Field { get; private set; }
        public IRenderer Renderer { get; private set; }

        public void CreateField()
        {
            Field = new Field(
                BoidsCount,
                EnemyCount
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
    }
}
