using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Object
{
    public class Square : Rectangle
    {

        public Square() { }

        public Square(int size)
        {
            Width = size;
            Height = size;
        }

        public override void SetHeight(int height)
        {
            Width = Height = height;   
        }

        public override void SetWidth(int width)
        {
            Width = Height = width;
        }
    }
}
