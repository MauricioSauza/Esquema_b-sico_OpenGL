using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;

namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(800, 600);
            Game gm = new Game(window);
        }
    }
}
