using System;
using System.Collections.Generic;
using System.Text;

namespace _034
{
    class Point
    {
       public int x,y;
       public char c;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
