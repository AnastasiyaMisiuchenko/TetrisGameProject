using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Tetris
{
    
    public partial class MainWindow : Window
    {
        List<Path> list = new List<Path>();
        private DispatcherTimer Timer;
        private int Speed;
        private Path Figure;
        Game Tetris;

        private int sizeCell = 40; // количество пикселей которое заниманиет одна ячейка (ячейка квадратная)
        private int nColumns = 10;
        private int nRows = 20;

        public MainWindow()
        {
            InitializeComponent();
            Tetris = new Game(GameCanvas, sizeCell, nColumns, nRows);
           
            Tetris.CreateUI();
            Tetris.Start();
            

            /*Draw Shape = new Draw();
            Figure = Shape.creatShape();
            Tetris.AddToCanvas(Figure);
            list.Add(Figure);
            Falling();*/


        }

        private void Pressing(object obj, KeyEventArgs press)
        {
            int Speed = Tetris.sizeCell;

            if(press.Key == Key.Left)
            {
                Figure = Tetris.shapes.ElementAt(0);
                double x = Canvas.GetLeft(Figure);
                Canvas.SetLeft(Figure, x - Speed);
            }
            if (press.Key == Key.Right)
            {
                Figure = Tetris.shapes.ElementAt(0);
                double x = Canvas.GetLeft(Figure);
                Canvas.SetLeft(Figure, x + Speed);
            }
            if (press.Key == Key.Space)
            {
                Figure = Tetris.shapes.ElementAt(0);
                double y = 960;
                Canvas.SetTop(Figure, y);
                
            }
            

        }

        private void Falling() //  no need
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(1000);
            Timer.Tick += IntervalTick;
            Timer.Start();
        }

        private void IntervalTick(object obj, EventArgs e) //no need
        {
            Speed += 12;
            Canvas.SetTop(Figure, Speed);

            double GetTpo = Canvas.GetTop(Figure);
            double Heigth = Figure.Height;
            if (GetTpo + Heigth >= 960)
                Timer.Stop();
        }

           
    }
}
