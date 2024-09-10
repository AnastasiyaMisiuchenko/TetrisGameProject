using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris
{
    internal abstract class TetrisShapes
    {
       public abstract Path Create(int size);
    }

    internal class ShapeT : TetrisShapes
    {
        public override Path Create(int size)
        {

            PathFigure tetrisFigure = new PathFigure { StartPoint = new Point(0, 0) };

            tetrisFigure.Segments.Add(new LineSegment(new Point(size * 2, 0), true));
            tetrisFigure.Segments.Add(new LineSegment(new Point(size * 2, size * 2), true));
            tetrisFigure.Segments.Add(new LineSegment(new Point(0, size * 2), true));
            tetrisFigure.Segments.Add(new LineSegment(new Point(0, 0), true));

            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.Figures.Add(tetrisFigure);

            Path tetrisShape = new Path
            {
                Stroke = Brushes.IndianRed,
                Fill = Brushes.DarkRed,
                StrokeThickness = 3,
                Data = pathGeometry,
                Height = size * 2,
                Width = size * 2
            };

            return tetrisShape;
        }

    }
}
