using Model;
using Renderer;
using SkiaSharp;

namespace Controller
{
    public class Controller
    {
        Field _field;

        public Field Field
        {
            get => _field;
            set => _field = value;
        }

        public IRenderer Renderer
        {
            get => _renderer;
            set => _renderer = value;
        }

        IRenderer _renderer;

        public Controller()
        {
            
        }

        public void CreateField(float width, float height)
        {
            _field = new Field(
                width: width, // to fix
                height: height, // to fix
                boidsCount: 100, // to fix
                enemyCount: 10 // to fix
            );
        }

        public void CreateRenderer(IRenderer renderer)
        {
            _renderer = renderer;
        }


    }
}
