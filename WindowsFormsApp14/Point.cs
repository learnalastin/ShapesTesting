using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    public class Points:Shapes
    {
 

        // no argument constructor
        public  Points()
        {
           // setPoint(0, 0);
            //setCoordinates(0, 0, 0, 0);
            setPoint(0, 0);
            
        }

        // constructor with four arguments
        public  Points(int a, int b, int c , int d)
        {
           setPoint(a, b);
           //setCoordinates(a,b,c,d);


        }

       public override void DrawShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.Green), x1, y1,0 , 0);
    
        }

    


        public override void DeleteShape(Graphics g)
        {
            g.DrawLine(new Pen(Color.Green), x1, y1, 0, 0);
        }


    }
}
