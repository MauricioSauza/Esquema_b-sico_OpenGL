using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Casa
{
    class Walls
    {
        private float length, height, width;
        private Color color = Color.SandyBrown;
        private Vector3 vector;

        public Walls(Vector3 v, float length, float height, float width)
        {
            vector = v;
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public void draw()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            // CARA TRASERA
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z + width);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z + width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z + width);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z + width);
            GL.End();

            // CARA FRONTAL
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z - width);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z - width);
            GL.End();

            // CARA IZQUIERDA
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z + width);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z + width);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z - width);
            GL.End();

            // CARA DERECHA
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z + width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z + width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z - width);
            GL.End();

            // CARA SUPERIOR
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y + height, vector.Z + width);
            GL.Vertex3(vector.X - length, vector.Y + height, vector.Z + width);
            GL.End();

            // CARA INFERIOR
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z - width);
            GL.Vertex3(vector.X + length, vector.Y - height, vector.Z + width);
            GL.Vertex3(vector.X - length, vector.Y - height, vector.Z + width);
            GL.End();


            GL.Flush();

        }

    }
}
