using System;
using MultipleShapes;
using SplashKitSDK;

public class Program
{
    private enum ShapeKind
    {
        Rectangle,
        Circle,
        Line
    } 

    public static void Main()
    {
        new Window("Drawing Shape", 800, 600);
        Drawing drawingshape = new Drawing();

        ShapeKind kindToAdd = ShapeKind.Circle;

        do
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();

            if (SplashKit.KeyTyped(KeyCode.RKey))
            {
                kindToAdd = ShapeKind.Rectangle;
            }

            if (SplashKit.KeyTyped(KeyCode.CKey))
            {
                kindToAdd = ShapeKind.Circle;
            }

            if (SplashKit.KeyTyped(KeyCode.LKey))
            {
                kindToAdd = ShapeKind.Line;
            }

            if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                Shape newShape;

                if (kindToAdd == ShapeKind.Rectangle)
                {
                    MyRectangle newRect = new MyRectangle();                    
                    newShape = newRect;
                }

                else if (kindToAdd == ShapeKind.Circle)
                {
                    MyCircle newCircle = new MyCircle();                   
                    newShape = newCircle;
                }      

                else
                {
                    MyLine newLine = new MyLine();                   
                    newShape = newLine;
                }

                newShape.X = SplashKit.MouseX();
                newShape.Y = SplashKit.MouseY();

                drawingshape.AddShape(newShape);
            }

            if (SplashKit.MouseClicked(MouseButton.RightButton))
            {
                drawingshape.SelectShapesAt(SplashKit.MousePosition());
   
            }

            if (SplashKit.KeyReleased(KeyCode.DeleteKey) || SplashKit.KeyReleased(KeyCode.BackspaceKey))
            {
                foreach (Shape shape in drawingshape.SelectedShapes)
                {
                    drawingshape.RemoveShape(shape);
                }
            }

            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                drawingshape.Background = SplashKit.RandomRGBColor(255);
            }

            drawingshape.Draw();
            SplashKit.RefreshScreen();

        }
        while (!SplashKit.WindowCloseRequested("Drawing Shape"));

    }
}
