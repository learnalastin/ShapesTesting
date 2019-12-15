using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShapesSet:Shapes
    {
        public override void DeleteShape(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void DrawShape(Graphics g)
        {
            throw new NotImplementedException();
        }

        public class ShapeList : SortedSet<Shapes>
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
