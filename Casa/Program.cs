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
            Game game = new Game(800, 600, "Drawing a House");
            game.Run(60.0);
        }
    }
}
