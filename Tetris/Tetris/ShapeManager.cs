using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Tetris
{
    internal static class ShapeManager
    {
        public static Path getShapeT(int size)
        {
            return new ShapeT().Create(size);
        }

        public static Path getRandomShape(int size)
        {
            Path result;
            int amountShapes = 1;//7
            Random random = new Random();
            int getShape = random.Next(0, amountShapes);

            switch (getShape)
            {
                case 0:
                    result = getShapeT(size);
                    break;
                default:
                    result = getShapeT(size);
                    break;
            }

            return result;
        }
    }
}
