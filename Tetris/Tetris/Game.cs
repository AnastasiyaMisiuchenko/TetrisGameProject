using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Tetris
{
    internal class Game
    {

        Canvas canvas;
        private DispatcherTimer Timer;
        public int sizeCell;
        private int nColumns;
        private int nRows;
        public List<Path> shapes = new List<Path>();

        private long lastTick = 0;
        private readonly double interval = 1000.0;

        public Game(Canvas canvas, int sizeCell, int nColumns, int nRows)
        {
            this.canvas = canvas;
            this.sizeCell = sizeCell;
            this.nColumns = nColumns;
            this.nRows = nRows; 
        }
        public void CreateUI()
        {
            CreatePointsTable();
            Field();
        }
        public void Start()
        {
            CompositionTarget.Rendering += OnRendering;

        }

        private void OnRendering(object sender, EventArgs e)
        {
            if (!(e is RenderingEventArgs renderingArgs))
                return;

            long currentTick = renderingArgs.RenderingTime.Ticks;
            double elapsedMillis = (currentTick - lastTick) / TimeSpan.TicksPerMillisecond;

            if (elapsedMillis >= interval)
            {
                lastTick = currentTick;
                Update(); // Ваш метод обновления
            }
        }

        public Path getNewRandomShape()
        {
            return ShapeManager.getRandomShape(sizeCell);
        }

        public void Update()
        {
            bool needCreate = shapes.Count == 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                /* if (shapes[i].isFalling) {
                     isOneShapeFalling = true;
                     break;
                 }
                */
                double x = Canvas.GetLeft(shapes[i]);
                double y = Canvas.GetTop(shapes[i]);

                if(y + shapes[i].ActualHeight < sizeCell * nRows)
                {
                    Canvas.SetTop(shapes[i], y + sizeCell);
                }
            }

            if (needCreate)
            {
                Path shape = getNewRandomShape();

                Random rnd = new Random();
                int sizeFigure = Convert.ToInt32(shape.ActualWidth / sizeCell);
                int indCell = rnd.Next(nColumns - sizeFigure);

                AddToCanvas(shape, indCell * sizeCell);
                shapes.Add(shape);
                
            }

           
            
        }

        public void AddToCanvas(Path shape)
        {
            canvas.Children.Add(shape);
            Canvas.SetLeft(shape, 5);
            Canvas.SetTop(shape, 5);

        }

        public void AddToCanvas(Path shape, int x)
        {

            canvas.Children.Add(shape);
            Canvas.SetLeft(shape, 5 + x);
            Canvas.SetTop(shape, 5);

        }
        public void Field()
        {
            RectangleGeometry field1 = new RectangleGeometry(new Rect(0, 0,nColumns * sizeCell, nRows * sizeCell));
            Path Field = new Path
            {
                Stroke = Brushes.WhiteSmoke,
                Fill = Brushes.Black,
                StrokeThickness = 3,
                Data = field1,
            };
            AddToCanvas(Field);

        }

        public void CreatePointsTable()
        {
            Rectangle Rect = new Rectangle
            {
                Width = 200,
                Height = 100,
                Stroke = Brushes.WhiteSmoke,
                StrokeThickness = 3,
                Fill = Brushes.Black
            };
            canvas.Children.Add(Rect);
            Canvas.SetTop(Rect, 3);
            Canvas.SetLeft(Rect, 1030);

            TextBlock Text = new TextBlock
            {
                Text = "Points",
                FontSize = 20,
                Foreground = Brushes.White,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextAlignment = TextAlignment.Center,
                Width = Rect.Width,
                Height = Rect.Height
            };
            canvas.Children.Add(Text);
            Canvas.SetTop(Text, 8);
            Canvas.SetLeft(Text, 1030);
        }
    }
}
