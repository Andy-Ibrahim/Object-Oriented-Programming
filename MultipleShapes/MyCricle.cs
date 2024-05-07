using System;
using SplashKitSDK;

namespace MultipleShapes
{
	public class MyCircle : Shape
	{
		private int _radius;

        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }

        public MyCircle() : this (Color.Blue , 50) { }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }

            SplashKit.FillCircle(Color, X, Y, _radius);

        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 4);

        }

        public override bool IsAt(Point2D pt)
        {
            
            double a = (pt.X - X);
            double b = (pt.Y - Y);

            if (Math.Sqrt(a * a + b * b) < _radius)
            {
                return true;
            }
            return false;
        }

    }
}

