using System;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Point point = new Point();
            point.x = 2;
            point.y = 3;
            point.c = '*';
            point.Draw();

            Point point1 = new Point();
            point1.x = 4;
            point1.y = 5;
            point1.c = '*';
            point1.Draw();

            Console.ReadKey();
        }

        //static void Draw(int x,int y,char c)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(c);
        //}
    }
}
