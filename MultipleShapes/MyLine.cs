using System;
using SplashKitSDK;

namespace MultipleShapes
{
	public class MyLine: Shape
	{
        private int _length;
        

        public MyLine(Color clr, int length) : base(clr)
        {
            _length = length;
        }

        public MyLine() : this (Color.Red, 200) { }



        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, X + _length, Y);
        }


        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Blue, X, Y, 2);
            SplashKit.DrawCircle(Color.Blue, X + _length, Y, 2);

        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, X + _length, Y));
        }

    }
}

