using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    [Serializable]
    public class Line : Shapes
    {
        // no argument constructor
        public Line()
        {
            setCoordinates(0, 0, 0, 0);
        }

        // constructor with four arguments
        public Line(int a, int b, int w, int h)
        {
            setCoordinates(a, b, w, h);

        }



        public override void DrawShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.Green), x1, y1, x2, y2);
        }


        public override void DeleteShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.White), x1, y1, x2, y2);

        }



    }
}
