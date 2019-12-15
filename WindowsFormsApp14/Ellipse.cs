using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    [Serializable]
    //class Ellipse derives from Circle
    public class Ellipse : Circle
    {

        // no argument constructor
        public Ellipse()
        {
            setCoordinates(0, 0, 0, 0);
        }

        // constructor with four arguments
        public Ellipse(int a, int b, int w, int h)
        {
            setCoordinates(a, b, w, h);
        }

        public override void DrawShape(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Green), x1, y1, x2, y2);
        }
        public override void DeleteShape(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.White), x1, y1, x2, y2);
        }


    }
}