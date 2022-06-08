using System;
using System.Windows.Threading;
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
        private readonly DispatcherTimer _timer = new();

        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controler();
            Reset();

            _timer.Interval = TimeSpan.FromMilliseconds(10);
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _controller.Field.Advance();
            ResultField.InvalidateVisual();
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