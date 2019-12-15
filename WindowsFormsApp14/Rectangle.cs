using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    [Serializable]
    public class Rectangle : Line
    {
        // no argument constructor
        public Rectangle()
        {
            setCoordinates(0, 0, 0, 0);
        }

        // constructor with four arguments
        public Rectangle(int a, int b, int w, int h)
        {
            setCoordinates(a, b, w, h);
        }


        public override void DrawShape(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Green), x1, y1, x2, y2);
        }

        public override void DeleteShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.White), x1, y1, x2, y2);

        }

        internal void Inflate(Size inflateSize)
        {
            throw new NotImplementedException();
        }
    }
}
