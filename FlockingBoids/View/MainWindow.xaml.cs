using Renderer;
using Controller;

namespace View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Controler _controller;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controler();
            Reset();
        }

        private void Reset()
        {
            _controller.CreateField((float)Width, (float)Height);

        }

        private void SKElement_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            _controller.CreateRenderer(new RendererSkiaSharp(e.Surface.Canvas));
            _controller.Renderer.Render(_controller.Field);
        }
    }
}