using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ПР10
{
    class FunctionDrawer
    {
        private double startX;
        private double endX;
        private int width, height;
        private Bitmap bitmap;
        private double d;

        public Color FuncColor = Color.Black;
        public Color AxisesColor = Color.Red;
        public int PenWidth = 1;

        private Graphics g;

        public FunctionDrawer(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private int ConvertYToIndex(double y)
        {
            return Convert.ToInt32(height / 2 - y / d);
        }

        private int ConvertXToIndex(double x)
        {
            return Convert.ToInt32((x - startX) / d);
        }

        private double ConvertIndexToY(int indexY)
        {
            return (height / 2 - indexY) * d;
        }

        private double ConvertIndexToX(int indexX)
        {
            return d * indexX + startX;
        }

        private Point[] GetFunctionPoints(double startX, double endX, Func<double, double> func)
        {
            this.startX = startX;
            this.endX = endX;
            this.d = (endX - startX) / width;
            Point[] points = new Point[width];

            for (int x = 0; x < width; x++)
            {
                int y = ConvertYToIndex(func(ConvertIndexToX(x)));

                points[x] = new Point(x, y);
            }

            return points;
        }

        private Bitmap DrawPoints(Point[] points, Color color)
        {
            foreach (Point point in points)
                if (point.X > 0 && point.X < width && point.Y > 0 && point.Y < height)
                    bitmap.SetPixel(point.X, point.Y, color);

            return bitmap;
        }

        private Bitmap DrawConnectedPoints(Point[] points, Color color)
        {
            g.DrawLines(new Pen(color, PenWidth), points);

            return bitmap;
        }

        public Bitmap DrawFunction(double startX, double endX, Func<double, double> func, bool needDrawAxises, bool needConnectPoints = true)
        {
            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);

            Point[] funcPoints = GetFunctionPoints(startX, endX, func);

            if (needDrawAxises)
            {
                Point[] OY = new Point[height];
                Point[] OX = new Point[width];

                int zeroIndexX = ConvertXToIndex(0);
                int zeroIndexY = ConvertYToIndex(0);

                for (int y = 0; y < height; y++)
                {
                    OY[y] = new Point(zeroIndexX, y);
                }

                for (int x = 0; x < width; x++)
                {
                    OX[x] = new Point(x, zeroIndexY);
                }

                DrawPoints(OY, AxisesColor);
                DrawPoints(OX, AxisesColor);
            }

            if (needConnectPoints)
            {
                DrawConnectedPoints(funcPoints, FuncColor);
            }
            else
            {
                DrawPoints(funcPoints, FuncColor);
            }

            return bitmap;
        }
    }
}
