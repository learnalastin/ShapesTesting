using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class PolyLine : Shapes
    {

        // no argument constructor
        public PolyLine()
        {
            setCoordinates(0, 0, 0, 0);
        }

        // constructor with four arguments
        public PolyLine(int a, int b, int w, int h)
        {
            setCoordinates(a, b, w, h);

        }


        public override void DrawShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.Green), x1, y1, x2, y2);



        }

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

   


        public override void DeleteShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.White), x1, y1, x2, y2);

        }
















    }
}
