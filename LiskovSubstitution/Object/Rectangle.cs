using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Object
{
    public class Rectangle
    {
        protected int Width;
        protected int Height;

        public Rectangle() { }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }

        public virtual void SetWidth(int width)
        {
            Width = width;
        }

        public virtual void SetHeight(int height)
        {
            Height = height;
        }

        public virtual int GetArea()
        {
            return Width * Height;
        }
    }
}
