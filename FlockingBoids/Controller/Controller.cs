using Model;
using Renderer;

namespace Controller
{
    public class Controller
    {
        public Field Field { get; private set; }
        public IRenderer Renderer { get; private set; }

        private const int BoidsCount = 500;
        private const int EnemyCount = 5;

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
