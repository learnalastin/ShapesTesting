using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    public abstract class Shapes
    {
        // these shapes are defined with four coordinates
        public int x1, y1, x2, y2;

        // this method initializes the coordinates
        public void setCoordinates(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void setPoint(int x1,int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public void setSize(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }



        // DrawA.draw

        // abstract method to draw the shape
        public abstract void DrawShape(Graphics g);

        public abstract void DeleteShape(Graphics g);

    }
}
