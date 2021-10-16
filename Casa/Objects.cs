using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Casa
{
    class Objects
    {
        private float length, height, width;
        private Color color = Color.LightBlue;
        private Vector3 vector;

        public Objects(Vector3 v, float length, float height, float width)
        {
            vector = v;
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public void draw()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            //Puerta
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length / 3, vector.Y, vector.Z - width);
            GL.Vertex3(vector.X + length / 4, vector.Y, vector.Z - width);
            GL.Vertex3(vector.X + length / 4, vector.Y - height, vector.Z - width);
            GL.Vertex3(vector.X - length / 3, vector.Y - height, vector.Z - width);
            GL.End();

            //Ventana
            GL.Color4(color);
            GL.Begin(primitiveType);
            GL.Vertex3(vector.X - length, vector.Y + height / 3, vector.Z - width / 3);
            GL.Vertex3(vector.X - length, vector.Y + height / 3, vector.Z + width / 3);
            GL.Vertex3(vector.X - length, vector.Y - height / 3, vector.Z + width / 3);
            GL.Vertex3(vector.X - length, vector.Y - height / 3, vector.Z - width / 3);
            GL.End();


            GL.Flush(); //para limpiar
        }
    }
}
