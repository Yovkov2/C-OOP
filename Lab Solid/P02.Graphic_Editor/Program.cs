using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape square = new Square();

            GraphicEditor editor = new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(rectangle);
            editor.DrawShape(square);
        }
    }
}
