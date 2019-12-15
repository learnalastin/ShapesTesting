using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class shapesList:ShapesSet
    {
        //create 2Dlist class
        public class shapeList : List<Shapes>
        {
            public void Add(int x1, int x2, int y1, int y2)
            {
                var data = new Line
                {
                    x1 = x1,
                    x2 = x2,
                    y1 = y1,
                    y2 = y2
                };
                this.Add(data);
            }
        }
    }
}
