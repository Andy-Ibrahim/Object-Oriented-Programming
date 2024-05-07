using System;
using System.Collections.Generic;
using SplashKitSDK;


namespace DrawingClass
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Drawing Class", 800, 600);
            Drawing _drawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
            

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape _newshape = new Shape();
                    _newshape.X = SplashKit.MouseX();
                    _newshape.Y = SplashKit.MouseX();
                    
                    _drawing.AddShape(_newshape);
                                    
                }

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    _drawing.Background = SplashKit.RandomRGBColor(255);
                }


                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    _drawing.SelectShapesAt(SplashKit.MousePosition());
                }


                if (SplashKit.KeyDown(KeyCode.DeleteKey) || SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    foreach (Shape shape in _drawing.SelectedShapes)
                    {
                        _drawing.RemoveShape(shape);
                    }
                }

                _drawing.Draw();

                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);

        }

    }
}