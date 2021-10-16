using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
namespace Casa
{
    class Home
    {
        private float length, height, width;
        private Color color = Color.White;
        private Vector3 vector;

        private Walls walls;
        private Roof roof;
        private Objects objects;

        public Home(Vector3 v, float length, float height, float width)
        {
            vector = v;
            this.length = length;
            this.width = width;
            this.height = height;

            walls = new Walls(v, length, height, width);
            roof = new Roof(v, length, height, width);
            objects = new Objects(v, length, height, width);
        }

        public void draw()
        {
            walls.draw();
            roof.draw();
            objects.draw();
        }


    }
}
