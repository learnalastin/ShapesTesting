using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Dynamic;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp14
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        List<Line> L = new List<Line>();
        List<Circle> C = new List<Circle>();
        List<Rectangle> R = new List<Rectangle>();
        List<Ellipse> E = new List<Ellipse>();
        List<Points> P = new List<Points>();
        List<PolyLine> Pol = new List<PolyLine>();

        List<Shapes> Lst = new List<Shapes>();

        private void button1_Click(object sender, EventArgs e)
        {
            // line

            Graphics g = CreateGraphics();


            Pen p = new Pen(Color.Green);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Line l = new Line(x1, y1, x2, y2);
            this.L.Add(l);

            foreach (var L in this.L)
            {
                // GlobalFunc.Draw(g, 100, 200, 300, 400);
                l.DrawShape(g);
            }


        }






        /*

                   public override void Draw(Graphics g)
        {
            Point[] PointArray = new Point[PointList.Count];
            PointArray = PointList.ToArray();
            for (int i = 0; i < PointList.Count; i++)
                g.DrawLines(new Pen(Color.Black), PointArray);
        }


    */

        private void button2_Click(object sender, EventArgs e)
        {
            //Circle
            Graphics g = CreateGraphics();


            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Circle c = new Circle(x1, y1, x2, y2);
            this.C.Add(c);


            foreach (var C in this.C)
            {
                c.DrawShape(g);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // rectangle
            Graphics g = CreateGraphics();

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Rectangle r = new Rectangle(x1, y1, x2, y2);
            this.R.Add(r);


            foreach (var R in this.R)
            {
                r.DrawShape(g);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ellipse
            Graphics g = CreateGraphics();



            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Ellipse o = new Ellipse(x1, y1, x2, y2);
            this.E.Add(o);


            foreach (var E in this.E)
            {
                o.DrawShape(g);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i; // = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);


            for (i = 0; i < E.Count; i++)
            {

                E[i].DeleteShape(g);
                E[i].setCoordinates(x1, y1, x2, y2);
                E[i].DrawShape(g);

                //i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i; // = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            for (i = 0; i < R.Count; i++)
            {
                R[i].DeleteShape(g);
                R[i].setCoordinates(x1, y1, x2, y2);
                R[i].DrawShape(g);
                //i++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i; // = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            for (i = 0; i < C.Count; i++)
            {
                C[i].DeleteShape(g);
                C[i].setCoordinates(x1, y1, x2, y2);
                C[i].DrawShape(g);

                //i++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i; // = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            for (i = 0; i < L.Count; i++)
            {
                L[i].DeleteShape(g);
                L[i].setCoordinates(x1, y1, x2, y2);

                L[i].DrawShape(g);
                //i++;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p = new Pen(Color.Green);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = e.X.ToString();
            textBox4.Text = e.Y.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Point
            Graphics g = CreateGraphics();


            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox1.Text);
            int y2 = int.Parse(textBox2.Text);

            Points p = new Points(x1, y1, 0, 0);

            foreach (var C in this.C)
            {
                p.DrawShape(g);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i; // = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            for (i = 0; i < P.Count; i++)
            {
                P[i].DeleteShape(g);
                P[i].setCoordinates(x1, y1, x2, y2);

                P[i].DrawShape(g);
                //i++;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        //    P.Add(x1,x2);
         //   base.OnMouseDown(e);
        //    this.Invalidate();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
   

            Pol.Add(new PolyLine { StartPoint = new Point(x1, y1), EndPoint = new Point(x2, y2) });

            for (int i = 0; i < Pol.Count; i++)
            {
                Pol[i].DrawShape(g);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();



            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Ellipse o = new Ellipse(x1, y1, x2, y2);
            this.Lst.Add(o);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // rectangle
            Graphics g = CreateGraphics();

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Rectangle r = new Rectangle(x1, y1, x2, y2);
            this.Lst.Add(r);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Circle
            Graphics g = CreateGraphics();


            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Circle c = new Circle(x1, y1, x2, y2);
            this.Lst.Add(c);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();


            Pen p = new Pen(Color.Green);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);



            Line l = new Line(x1, y1, x2, y2);
            this.Lst.Add(l);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Line l = new Line();
            this.Lst.Remove(l);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            this.Lst.Remove(c);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            this.Lst.Remove(r);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ellipse o = new Ellipse();
            this.Lst.Remove(o);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Shapes.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив 
                formatter.Serialize(fs, Lst);

                Console.WriteLine("Объект сериализован");
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("Shapes.dat", FileMode.OpenOrCreate))
            {
                Shapes newShapes = (Shapes) formatter.Deserialize(fs);


            }

            Console.ReadLine();

       }



        public void CopyValues<T>(T target, T source)
        {
            Type t = typeof(T);

            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(source, null);
                if (value != null)
                    prop.SetValue(target, value, null);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {


            Graphics g = CreateGraphics();


            Pen p = new Pen(Color.Green);
            RectangleF rectangle1 = new RectangleF(30, 40, 50, 100);
            RectangleF rectangle2 = new RectangleF(50, 60, 100, 60);
   
            // Declare a third rectangle as a union of the first two.
         //   Rectangle rectangle3 = Rectangle.Union(rectangle1, rectangle2);
          //  g.DrawRectangle(p,rectangle3);
            

        }

        GraphicsPath MirrorLeft(GraphicsPath path)
        {
            var r = path.GetBounds();
            var p = (GraphicsPath)path.Clone();
            p.Transform(new Matrix(-1, 0, 0, 1, 2 * r.Left, 0));
            return p;
        }
        GraphicsPath MirrorRight(GraphicsPath path)
        {
            var r = path.GetBounds();
            var p = (GraphicsPath)path.Clone();
            p.Transform(new Matrix(-1, 0, 0, 1, 2 * (r.Left + r.Width), 0));
            return p;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path1 = new GraphicsPath())
            {
                path1.AddArc(new RectangleF(100, 100, 200, 200), -90, 90);
                using (var pen1 = new Pen(Color.Red, 3))
                    e.Graphics.DrawPath(pen1, path1);

                using (var path2 = MirrorLeft(path1))
                using (var pen2 = new Pen(Color.Green, 3))
                    e.Graphics.DrawPath(pen2, path2);
                using (var path3 = MirrorRight(path1))
                using (var pen3 = new Pen(Color.Blue, 3))
                    e.Graphics.DrawPath(pen3, path3);
            }
            base.OnPaint(e);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            // Create a rectangle.
            Rectangle rect = new Rectangle(100, 100, 50, 50);

            
            // Draw the uninflated rectangle to screen.
            rect.DrawShape(g);

            // Set up the inflate size.
            Size inflateSize = new Size(50, 50);

            // Call Inflate.
            rect.Inflate(inflateSize);

            // Draw the inflated rectangle to screen.
            rect.DrawShape(g);
        }
    }
}

