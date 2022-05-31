using System.Windows;
using Model;
using Renderer;

namespace View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Field field;

        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            field = new Field(
                width: (float)Width, // to fix
                height: (float)Height, // to fix
                boidsCount: 100, // to fix
                enemyCount: 10 // to fix
            );

        }

        private void SKElement_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var renderer = new RendererSkiaSharp(e.Surface.Canvas);
            renderer.Render(field);
        }
    }
}