using System;
using SplashKitSDK;

namespace MultipleShapes
{
	public abstract class Shape
	{
        private Color _color;
        private float _x, _y;
        private bool _selected;


        public Shape(Color clr)
        {
            this._color = clr;
            _x = 0;
            _y = 0;
            _selected = true;
        }


        public float X
        {
            get { return this._x; }
            set { this._x = value; }
        }


        public float Y
        {
            get { return this._y; }
            set { this._y = value; }
        }


        public bool Selected
        {
            get { return this._selected; }
            set { this._selected = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }


        public abstract void Draw();


        public abstract void DrawOutline();
        

        public abstract bool IsAt(Point2D pt);
             
    }
}

