using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris
{
    internal class Draw
    {
        public int x, y;
        public Path shape;

        public Path creatShape()
        {
            RectangleGeometry part1one = new RectangleGeometry(new Rect(5, 5, 60, 60));
            RectangleGeometry part2one = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part3one = new RectangleGeometry(new Rect(5, 65, 60, 60));
            RectangleGeometry part4one = new RectangleGeometry(new Rect(5, 125, 60, 60));
            CombinedGeometry FirstPartOne = new CombinedGeometry(part1one, part2one);
            CombinedGeometry SecondPartOne = new CombinedGeometry(part3one, part4one);
            CombinedGeometry ThirdPartOne = new CombinedGeometry(FirstPartOne, SecondPartOne);
            Path FirstShape = new Path
            {
                Stroke = Brushes.LightPink,
                Fill = Brushes.HotPink,
                StrokeThickness = 2,
                Data = ThirdPartOne,
                Height = 190,
            };
            position(FirstShape);

            RectangleGeometry part1two = new RectangleGeometry(new Rect(5, 5, 60, 60));
            RectangleGeometry part2two = new RectangleGeometry(new Rect(65, 5, 60, 60));
            RectangleGeometry part3two = new RectangleGeometry(new Rect(125, 5, 60, 60));
            RectangleGeometry part4two = new RectangleGeometry(new Rect(185, 5, 60, 60));
            CombinedGeometry FirstPartTwo = new CombinedGeometry(part1two, part2two);
            CombinedGeometry SecondPartTwo = new CombinedGeometry(part3two, part4two);
            CombinedGeometry ThirdPartTwo = new CombinedGeometry(FirstPartTwo, SecondPartTwo);
            Path SecondShape = new Path
            {
                Stroke = Brushes.LightYellow,
                Fill = Brushes.Yellow,
                StrokeThickness = 2,
                Data = ThirdPartTwo,
                Height = 70,
            };
            position(SecondShape);

            RectangleGeometry part1three = new RectangleGeometry(new Rect(5, 5, 60, 60));
            RectangleGeometry part2three = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part3three = new RectangleGeometry(new Rect(5, 65, 60, 60));
            RectangleGeometry part4three = new RectangleGeometry(new Rect(125, 65, 60, 60));
            CombinedGeometry FirstPartThree = new CombinedGeometry(part1three, part2three);
            CombinedGeometry SecondPartThree = new CombinedGeometry(part3three, part4three);
            CombinedGeometry ThirdPartThree = new CombinedGeometry(FirstPartThree, SecondPartThree);
            Path ThirdShape = new Path
            {
                Stroke = Brushes.LightGreen,
                Fill = Brushes.LimeGreen,
                StrokeThickness = 2,
                Data = ThirdPartThree,
                Height = 130,
            };
            position(ThirdShape);

            RectangleGeometry part1four = new RectangleGeometry(new Rect(5, 65, 60, 60));
            RectangleGeometry part2four = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part3four = new RectangleGeometry(new Rect(125, 65, 60, 60));
            RectangleGeometry part4four = new RectangleGeometry(new Rect(125, 5, 60, 60));
            CombinedGeometry FirstPartFourth = new CombinedGeometry(part1four, part2four);
            CombinedGeometry SecondPartFourth = new CombinedGeometry(part3four, part4four);
            CombinedGeometry ThirdPartFourth = new CombinedGeometry(FirstPartFourth, SecondPartFourth);
            Path FourthShape = new Path
            {
                Stroke = Brushes.SkyBlue,
                Fill = Brushes.DeepSkyBlue,
                StrokeThickness = 2,
                Data = ThirdPartFourth,
                Height = 130,
            };
            position(FourthShape);

            RectangleGeometry part1five = new RectangleGeometry(new Rect(5, 5, 60, 60));
            RectangleGeometry part2five = new RectangleGeometry(new Rect(5, 65, 60, 60));
            RectangleGeometry part3five = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part4five = new RectangleGeometry(new Rect(65, 5, 60, 60));
            CombinedGeometry FirstPartFifth = new CombinedGeometry(part1five, part2five);
            CombinedGeometry SecondPartFifth = new CombinedGeometry(part3five, part4five);
            CombinedGeometry ThirdPartFifth = new CombinedGeometry(FirstPartFifth, SecondPartFifth);
            Path FifthShape = new Path
            {
                Stroke = Brushes.OrangeRed,
                Fill = Brushes.DarkOrange,
                StrokeThickness = 2,
                Data = ThirdPartFifth,
                Height = 130,
            };
            position(FifthShape);

            RectangleGeometry part1six = new RectangleGeometry(new Rect(5, 5, 60, 60));
            RectangleGeometry part2six = new RectangleGeometry(new Rect(65, 5, 60, 60));
            RectangleGeometry part3six = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part4six = new RectangleGeometry(new Rect(125, 65, 60, 60));
            CombinedGeometry FirstPartSixth = new CombinedGeometry(part1six, part2six);
            CombinedGeometry SecondPartSixth = new CombinedGeometry(part3six, part4six);
            CombinedGeometry ThirdPartSixth = new CombinedGeometry(FirstPartSixth, SecondPartSixth);
            Path SixthShape = new Path
            {
                Stroke = Brushes.IndianRed,
                Fill = Brushes.DarkRed,
                StrokeThickness = 2,
                Data = ThirdPartSixth,
                Height = 130,
            };
            position(SixthShape);

            RectangleGeometry part1seven = new RectangleGeometry(new Rect(5, 65, 60, 60));
            RectangleGeometry part2seven = new RectangleGeometry(new Rect(65, 65, 60, 60));
            RectangleGeometry part3seven = new RectangleGeometry(new Rect(65, 5, 60, 60));
            RectangleGeometry part4seven = new RectangleGeometry(new Rect(125, 5, 60, 60));
            CombinedGeometry FirstPartSeventh = new CombinedGeometry(part1seven, part2seven);
            CombinedGeometry SecondPartSeventh = new CombinedGeometry(part3seven, part4seven);
            CombinedGeometry ThirdPartSeventh = new CombinedGeometry(FirstPartSeventh, SecondPartSeventh);
            Path SeventhShape = new Path
            {
                Stroke = Brushes.Violet,
                Fill = Brushes.Indigo,
                StrokeThickness = 2,
                Data = ThirdPartSeventh,
                Height = 130,
            };
            position(SeventhShape);

            Path[] ArrayShape = new Path[7];
            ArrayShape[0] = FirstShape;
            ArrayShape[1] = SecondShape;
            ArrayShape[2] = ThirdShape;
            ArrayShape[3] = FourthShape;
            ArrayShape[4] = FifthShape;
            ArrayShape[5] = SixthShape;
            ArrayShape[6] = SeventhShape;

            Random Rand = new Random();

            return ArrayShape[Rand.Next(0, 6)];
        }

        public void position(Path shape)
        {
            const int y = 7;
            Random Rand = new Random();
            int x = Rand.Next(7, 760);
            Canvas.SetTop(shape, y);
            Canvas.SetLeft(shape, x);
        }


    }
}

